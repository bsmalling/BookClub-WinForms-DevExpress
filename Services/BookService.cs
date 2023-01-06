using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Win.Hook;
using DevExpress.XtraNavBar;
using BookClub.Models;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace BookClub.Services
{

    public class BookService : BaseService
    {

        public BookService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public Book Create(Book book)
        {
            string sqlCommand = GetSqlCommand("Books/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Description", book.Description);
            command.Parameters.AddWithValue("@Pages", book.Pages);
            command.Parameters.AddWithValue("@ISBN", book.ISBN);
            command.Parameters.AddWithValue("@ASIN", book.ASIN);
            command.Parameters.AddWithValue("@ThumbnailId", book.ThumbnailId);
            command.Parameters.AddWithValue("@Published", book.Published);
            LoadObjects(book);

            int id = Convert.ToInt32(command.ExecuteScalar());
            book.Status = ChangeStatus.None;
            book.ServiceSetId__(id);
            return book;
        }

        public Book Read(int id)
        {
            string sqlCommand = GetSqlCommand("Books/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            Book book = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    book = new Book((int)reader["Id"]);
                    book.Title = (string)reader["Title"];
                    book.Author = (string)reader["Author"];
                    book.Description = ConvertDBVal<string>(reader["Description"]);
                    book.Pages = (int?)reader["Pages"];
                    book.ISBN = ConvertDBVal<string>(reader["ISBN"]);
                    book.ASIN = ConvertDBVal<string>(reader["ASIN"]);
                    book.ThumbnailId = ConvertDBInt(reader["ThumbnailId"]);
                    book.Published = (DateTime)reader["Published"];
                }
            }
            if (book != null)
                LoadObjects(book);
            return book;
        }

        public bool Update(Book book)
        {
            string sqlCommand = GetSqlCommand("Books/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", book.Id);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Description", book.Description);
            command.Parameters.AddWithValue("@Pages", book.Pages);
            command.Parameters.AddWithValue("@ISBN", book.ISBN);
            command.Parameters.AddWithValue("@ASIN", book.ASIN);
            command.Parameters.AddWithValue("@ThumbnailId", book.ThumbnailId);
            command.Parameters.AddWithValue("@Published", book.Published);

            if (command.ExecuteNonQuery() > 0)
            {
                book.Status = ChangeStatus.None;
                LoadObjects(book, true);
                return true;
            }
            return false;
        }

        public int UpdateAll(List<Book> books)
        {
            int count = 0;
            for (int i = books.Count - 1; i >= 0; i--)
            {
                var book = books.ElementAt<Book>(i);
                bool updated = false;

                switch (book.Status)
                {
                    case ChangeStatus.New:
                        Create(book);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(book);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(book.Id);
                        books.RemoveAt(i);
                        break;
                    default:
                        break;
                }
                if (updated) count += 1;
            }
            return count;
        }

        public bool Delete(int id)
        {
            string sqlCommand = GetSqlCommand("Books/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Book);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Book> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Books/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var books = new List<Book>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var book = new Book((int)reader["Id"]);
                    book.Title = (string)reader["Title"];
                    book.Author = (string)reader["Author"];
                    book.Description = ConvertDBVal<string>(reader["Description"]);
                    book.Pages = (int?)reader["Pages"];
                    book.ISBN = ConvertDBVal<string>(reader["ISBN"]);
                    book.ASIN = ConvertDBVal<string>(reader["ASIN"]);
                    book.ThumbnailId = ConvertDBInt(reader["ThumbnailId"]);
                    book.Published = (DateTime)reader["Published"];
                    books.Add(book);
                }
            }
            foreach (var book in books)
                LoadObjects(book);
            return books;
        }

        private void LoadObjects(Book book, bool force = false)
        {
            if (force || (book.ThumbnailId.HasValue && book.Thumbnail == null))
            {
                using (var thumbnailService = new ThumbnailService(m_connection))
                    book.Thumbnail = thumbnailService.Read(book.ThumbnailId.Value);
            }
        }

    }

}

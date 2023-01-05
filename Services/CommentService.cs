using DevExpress.Utils.Win.Hook;
using BookClub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace BookClub.Services
{

    public class CommentService : BaseService
    {

        public CommentService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public Comment Create(Comment comment)
        {
            string sqlCommand = GetSqlCommand("Comments/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@ParentType", comment.ParentType);
            command.Parameters.AddWithValue("@ParentId", comment.ParentId);
            command.Parameters.AddWithValue("@Text", comment.Text);
            command.Parameters.AddWithValue("@UserId", comment.UserId);
            command.Parameters.AddWithValue("@Created", comment.Created);
            LoadObjects(comment);

            int id = Convert.ToInt32(command.ExecuteScalar());
            comment.Status = ChangeStatus.None;
            comment.ServiceSetId__(id);
            return comment;
        }

        public Comment Read(int id)
        {
            string sqlCommand = GetSqlCommand("Comments/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            Comment comment = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    comment = new Comment((int)reader["Id"]);
                    comment.ParentType = (ParentType)reader["ParentType"];
                    comment.ParentId = (int)reader["ParentId"];
                    comment.Text = (string)reader["Text"];
                    comment.UserId = (int)reader["UserId"];
                    comment.Created = (DateTime)reader["Created"];
                }
            }
            if (comment != null)
                LoadObjects(comment);
            return comment;
        }

        public List<Comment> ReadByParent(ParentType parentType, int parentId)
        {
            string sqlCommand = GetSqlCommand("Comments/ReadByParent");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@ParentType", parentType);
            command.Parameters.AddWithValue("@ParentId", parentId);

            var comments = new List<Comment>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var comment = new Comment((int)reader["Id"]);
                    comment.ParentType = (ParentType)reader["ParentType"];
                    comment.ParentId = (int)reader["ParentId"];
                    comment.Text = (string)reader["Text"];
                    comment.UserId = (int)reader["UserId"];
                    comment.Created = (DateTime)reader["Created"];
                    comments.Add(comment);
                }
            }
            foreach (var comment in comments)
                LoadObjects(comment);
            return comments;
        }

        public bool Update(Comment comment)
        {
            string sqlCommand = GetSqlCommand("Comments/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", comment.Id);
            command.Parameters.AddWithValue("@ParentType", comment.ParentType);
            command.Parameters.AddWithValue("@ParentId", comment.ParentId);
            command.Parameters.AddWithValue("@Text", comment.Text);
            command.Parameters.AddWithValue("@UserId", comment.UserId);
            command.Parameters.AddWithValue("@Created", comment.Created);

            if (command.ExecuteNonQuery() > 0)
            {
                comment.Status = ChangeStatus.None;
                LoadObjects(comment, true);
                return true;
            }
            return false;
        }

        public int UpdateAll(ParentType parentType, int parentId, List<Comment> comments)
        {
            int count = 0;
            for (int i = comments.Count - 1; i >= 0; i--)
            {
                var comment = comments[i];
                comment.ParentType = parentType;
                comment.ParentId = parentId;
                bool updated = false;

                switch (comment.Status)
                {
                    case ChangeStatus.New:
                        Create(comment);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(comment);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(comment.Id);
                        comments.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Comments/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Comment);

            return command.ExecuteNonQuery() > 0;
        }

        public bool DeleteByParent(ParentType parentType, int parentId)
        {
            string sqlCommand = GetSqlCommand("Comments/DeleteByParent");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@ParentType", parentType);
            command.Parameters.AddWithValue("@ParentId", parentId);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Comment> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Comments/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var comments = new List<Comment>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var comment = new Comment((int)reader["Id"]);
                    comment.ParentType = (ParentType)reader["ParentType"];
                    comment.ParentId = (int)reader["ParentId"];
                    comment.Text = (string)reader["Text"];
                    comment.UserId = (int)reader["UserId"];
                    comment.Created = (DateTime)reader["Created"];
                    comments.Add(comment);
                }
            }
            foreach (var comment in comments)
                LoadObjects(comment);
            return comments;
        }

        private void LoadObjects(Comment comment, bool force = false)
        {
            if (force || comment.User == null)
            {
                var userService = new UserService(m_connection);
                comment.User = userService.Read(comment.UserId);
            }
        }

    }

}

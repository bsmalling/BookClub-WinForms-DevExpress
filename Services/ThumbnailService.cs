using BookClub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.Utils.HashCodeHelper.Primitives;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace BookClub.Services
{

    public class ThumbnailService : BaseService
    {

        public ThumbnailService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public Thumbnail Create(Thumbnail thumbnail)
        {
            string sqlCommand = GetSqlCommand("Thumbnails/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            var bytes = ImageToBytes(thumbnail.ImageObj);
            command.Parameters.Add("@Image", SqlDbType.VarBinary, -1).Value = bytes;

            int id = Convert.ToInt32(command.ExecuteScalar());
            thumbnail.Status = ChangeStatus.None;
            thumbnail.ServiceSetId__(id);
            return thumbnail;
        }

        public Thumbnail Read(int id)
        {
            string sqlCommand = GetSqlCommand("Thumbnails/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var thumbnail = new Thumbnail((int)reader["Id"]);
                    thumbnail.ImageObj = BytesToImage((byte[])reader["Image"]);
                    return thumbnail;
                }
            }
            return null;
        }

        public bool Update(Thumbnail thumbnail)
        {
            string sqlCommand = GetSqlCommand("Thumbnails/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", thumbnail.Id);
            var bytes = ImageToBytes(thumbnail.ImageObj);
            command.Parameters.AddWithValue("@Image", bytes);

            if (command.ExecuteNonQuery() > 0)
            {
                thumbnail.Status = ChangeStatus.None;
                return true;
            }
            return false;
        }

        public int UpdateAll(List<Thumbnail> thumbnails)
        {
            int count = 0;
            for (int i = thumbnails.Count - 1; i >= 0; i--)
            {
                var thumbnail = thumbnails[i];
                bool updated = false;

                switch (thumbnail.Status)
                {
                    case ChangeStatus.New:
                        Create(thumbnail);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(thumbnail);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(thumbnail.Id);
                        thumbnails.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Thumbnails/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Thumbnail);

            return command.ExecuteNonQuery() > 0;
        }

        public static byte[] ImageToBytes(Image image)
        {
            ImageConverter imageConverter = new ImageConverter();
            return (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
        }

        public static Image BytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookClub.Models;

namespace BookClub.Services
{

    public class UserService : BaseService
    {

        public UserService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public User GetByUsername(string username)
        {
            string sqlCommand = GetSqlCommand("Users/ReadByUsername");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Username", username);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var user = new User((int)reader["Id"], (string)reader["Username"]);
                    user.PwdHash = (string)reader["PwdHash"];
                    user.FirstName = (string)reader["FirstName"];
                    user.LastName = (string)reader["LastName"];
                    user.Email = (string)reader["Email"];
                    user.AboutMe = ConvertDBVal<string>(reader["AboutMe"]);
                    user.Role = (UserRole)reader["Role"];
                    return user;
                }
            }
            return null;
        }

        public User Create(User user)
        {
            string sqlCommand = GetSqlCommand("Users/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@PwdHash", user.PwdHash);
            command.Parameters.AddWithValue("@FirstName", user.FirstName);
            command.Parameters.AddWithValue("@LastName", user.LastName);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@About", user.AboutMe);
            command.Parameters.AddWithValue("@Role", user.Role);

            int id = Convert.ToInt32(command.ExecuteScalar());
            user.Status = ChangeStatus.None;
            user.ServiceSetId__(id);
            return user;
        }

        public User Read(int id)
        {
            string sqlCommand = GetSqlCommand("Users/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var user = new User((int)reader["Id"], (string)reader["Username"]);
                    user.PwdHash = (string)reader["PwdHash"];
                    user.FirstName = (string)reader["FirstName"];
                    user.LastName = (string)reader["LastName"];
                    user.Email = (string)reader["Email"];
                    user.AboutMe = ConvertDBVal<string>(reader["AboutMe"]);
                    user.Role = (UserRole)reader["Role"];
                    return user;
                }
            }
            return null;
        }

        public bool Update(User user)
        {
            string sqlCommand = GetSqlCommand("Users/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@PwdHash", user.PwdHash);
            command.Parameters.AddWithValue("@FirstName", user.FirstName);
            command.Parameters.AddWithValue("@LastName", user.LastName);
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@About", user.AboutMe);
            command.Parameters.AddWithValue("@Role", user.Role);

            if (command.ExecuteNonQuery() > 0)
            {
                user.Status = ChangeStatus.None;
                return true;
            }
            return false;
        }

        public int UpdateAll(List<User> users)
        {
            int count = 0;
            for (int i = users.Count - 1; i >= 0; i--)
            {
                var user = users[i];
                bool updated = false;

                switch (user.Status)
                {
                    case ChangeStatus.New:
                        Create(user);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(user);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(user.Id);
                        users.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Users/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.User);

            return command.ExecuteNonQuery() > 0;
        }

        public List<User> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Users/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var users = new List<User>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var user = new User((int)reader["Id"], (string)reader["Username"]);
                    user.PwdHash = (string)reader["PwdHash"];
                    user.FirstName = (string)reader["FirstName"];
                    user.LastName = (string)reader["LastName"];
                    user.Email = (string)reader["Email"];
                    user.AboutMe = ConvertDBVal<string>(reader["AboutMe"]);
                    user.Role = (UserRole)reader["Role"];
                    users.Add(user);
                }
            }
            return users;
        }

    }

}

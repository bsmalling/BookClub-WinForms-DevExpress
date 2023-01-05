using DevExpress.Utils.Win.Hook;
using BookClub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Services
{

    public class MeetingService : BaseService
    {

        public MeetingService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public Meeting Create(Meeting meeting)
        {
            string sqlCommand = GetSqlCommand("Meetings/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@BookId", meeting.BookId);
            command.Parameters.AddWithValue("@HostId", meeting.HostId);
            command.Parameters.AddWithValue("@LocationId", meeting.LocationId);
            command.Parameters.AddWithValue("@MeetTime", meeting.MeetTime);
            command.Parameters.AddWithValue("@Description", meeting.Description);
            LoadObjects(meeting);

            int id = Convert.ToInt32(command.ExecuteScalar());
            meeting.Status = ChangeStatus.None;
            meeting.ServiceSetId__(id);
            return meeting;
        }

        public Meeting Read(int id)
        {
            string sqlCommand = GetSqlCommand("Meetings/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            Meeting meeting = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    meeting = new Meeting((int)reader["Id"]);
                    meeting.BookId = (int)reader["BookId"];
                    meeting.HostId = (int)reader["HostId"];
                    meeting.LocationId = (int)reader["LocationId"];
                    meeting.MeetTime = (DateTime)reader["MeetTime"];
                    meeting.Description = ConvertDBVal<string>(reader["Description"]);
                }
            }
            if (meeting != null)
                LoadObjects(meeting);
            return meeting;
        }

        public bool Update(Meeting meeting)
        {
            string sqlCommand = GetSqlCommand("Meetings/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", meeting.Id);
            command.Parameters.AddWithValue("@BookId", meeting.BookId);
            command.Parameters.AddWithValue("@HostId", meeting.HostId);
            command.Parameters.AddWithValue("@LocationId", meeting.LocationId);
            command.Parameters.AddWithValue("@MeetTime", meeting.MeetTime);
            command.Parameters.AddWithValue("@Description", meeting.Description);

            if (command.ExecuteNonQuery() > 0)
            {
                meeting.Status = ChangeStatus.None;
                LoadObjects(meeting, true);
                return true;
            }
            return false;
        }

        public int UpdateAll(List<Meeting> meetings)
        {
            int count = 0;
            for (int i = meetings.Count - 1; i >= 0; i--)
            {
                var meeting = meetings[i];
                bool updated = false;

                switch (meeting.Status)
                {
                    case ChangeStatus.New:
                        Create(meeting);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(meeting);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(meeting.Id);
                        meetings.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Meetings/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Meeting);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Meeting> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Meetings/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var meetings = new List<Meeting>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var meeting = new Meeting((int)reader["Id"]);
                    meeting.BookId = (int)reader["BookId"];
                    meeting.HostId = (int)reader["HostId"];
                    meeting.LocationId = (int)reader["LocationId"];
                    meeting.MeetTime = (DateTime)reader["MeetTime"];
                    meeting.Description = ConvertDBVal<string>(reader["Description"]);
                    meetings.Add(meeting);
                }
            }
            foreach (var meeting in meetings)
                LoadObjects(meeting);
            return meetings;
        }

        private void LoadObjects(Meeting meeting, bool force = false)
        {
            if (force || meeting.Book == null)
            {
                var bookService = new BookService(m_connection);
                meeting.Book = bookService.Read(meeting.BookId);
            }
            if (force || meeting.Host == null)
            {
                var userService = new UserService(m_connection);
                meeting.Host = userService.Read(meeting.HostId);
            }
            if (force || meeting.Location == null)
            {
                var locationService = new LocationService(m_connection);
                meeting.Location = locationService.Read(meeting.LocationId);
            }
        }

    }

}

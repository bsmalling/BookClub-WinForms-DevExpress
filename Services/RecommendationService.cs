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

    public class RecommendationService : BaseService
    {

        public RecommendationService(SqlConnection connection)
        : base(connection)
        {
            // Intentionally blank
        }

        public Recommendation Create(Recommendation recommendation)
        {
            string sqlCommand = GetSqlCommand("Recommendations/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@MeetingId", recommendation.MeetingId);
            command.Parameters.AddWithValue("@BookId", recommendation.BookId);
            command.Parameters.AddWithValue("@UserId", recommendation.UserId);
            command.Parameters.AddWithValue("@Created", recommendation.Created);
            LoadObjects(recommendation);

            int id = Convert.ToInt32(command.ExecuteScalar());
            recommendation.Status = ChangeStatus.None;
            recommendation.ServiceSetId__(id);
            return recommendation;
        }

        public Recommendation Read(int id)
        {
            string sqlCommand = GetSqlCommand("Recommendations/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            Recommendation recommendation = null;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    recommendation = new Recommendation((int)reader["Id"]);
                    recommendation.MeetingId = (int)reader["MeetingId"];
                    recommendation.BookId = (int)reader["BookId"];
                    recommendation.UserId = (int)reader["UserId"];
                    recommendation.Created = (DateTime)reader["Created"];
                }
            }
            if (recommendation != null)
                LoadObjects(recommendation);
            return recommendation;
        }

        public List<Recommendation> ReadByMeeting(int parentId)
        {
            string sqlCommand = GetSqlCommand("Recommendations/ReadByMeeting");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@MeetingId", parentId);

            var recommendations = new List<Recommendation>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var recommendation = new Recommendation((int)reader["Id"]);
                    recommendation.MeetingId = (int)reader["MeetingId"];
                    recommendation.BookId = (int)reader["BookId"];
                    recommendation.UserId = (int)reader["UserId"];
                    recommendation.Created = (DateTime)reader["Created"];
                    recommendations.Add(recommendation);
                }
            }
            foreach (var recommendation in recommendations)
                LoadObjects(recommendation);
            return recommendations;
        }

        public bool Update(Recommendation recommendation)
        {
            string sqlCommand = GetSqlCommand("Recommendations/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", recommendation.Id);
            command.Parameters.AddWithValue("@MeetingId", recommendation.MeetingId);
            command.Parameters.AddWithValue("@BookId", recommendation.BookId);
            command.Parameters.AddWithValue("@UserId", recommendation.UserId);
            command.Parameters.AddWithValue("@Created", recommendation.Created);

            if (command.ExecuteNonQuery() > 0)
            {
                recommendation.Status = ChangeStatus.None;
                LoadObjects(recommendation, true);
                return true;
            }
            return false;
        }

        public int UpdateAll(int meetingId, List<Recommendation> recommendations)
        {
            int count = 0;
            for (int i = recommendations.Count - 1; i >= 0; i--)
            {
                var recommendation = recommendations[i];
                recommendation.MeetingId = meetingId;
                bool updated = false;

                switch (recommendation.Status)
                {
                    case ChangeStatus.New:
                        Create(recommendation);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(recommendation);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(recommendation.Id);
                        recommendations.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Recommendations/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Recommendation);

            return command.ExecuteNonQuery() > 0;
        }

        public bool DeleteByMeeting(int meetingId)
        {
            string sqlCommand = GetSqlCommand("Recommendations/DeleteByMeeting");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@MeetingId", meetingId);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Recommendation> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Recommendations/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var recommendations = new List<Recommendation>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var recommendation = new Recommendation((int)reader["Id"]);
                    recommendation.MeetingId = (int)reader["MeetingId"];
                    recommendation.BookId = (int)reader["BookId"];
                    recommendation.UserId = (int)reader["UserId"];
                    recommendation.Created = (DateTime)reader["Created"];
                    recommendations.Add(recommendation);
                }
            }
            foreach (var recommendation in recommendations)
                LoadObjects(recommendation);
            return recommendations;
        }

        private void LoadObjects(Recommendation recommendation, bool force = false)
        {
            if (force || recommendation.Meeting == null)
            {
                var meetingService = new MeetingService(m_connection);
                recommendation.Meeting = meetingService.Read(recommendation.MeetingId);
            }
            if (force || recommendation.Book == null)
            {
                var bookService = new BookService(m_connection);
                recommendation.Book = bookService.Read(recommendation.BookId);
            }
            if (force || recommendation.User == null)
            {
                var userService = new UserService(m_connection);
                recommendation.User = userService.Read(recommendation.UserId);
            }
        }

    }

}

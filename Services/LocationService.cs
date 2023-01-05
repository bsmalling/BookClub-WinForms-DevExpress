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

    public class LocationService : BaseService
    {

        public LocationService(SqlConnection connection)
            : base(connection)
        {
            // Intentionally blank
        }

        public Location Create(Location location)
        {
            string sqlCommand = GetSqlCommand("Locations/Create");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Address1", location.Address1);
            command.Parameters.AddWithValue("@Address2", location.Address2);
            command.Parameters.AddWithValue("@City", location.City);
            command.Parameters.AddWithValue("@State", location.State);
            command.Parameters.AddWithValue("@Zip", location.Zip);
            command.Parameters.AddWithValue("@Description", location.Description);

            int id = Convert.ToInt32(command.ExecuteScalar());
            location.Status = ChangeStatus.None;
            location.ServiceSetId__(id);
            return location;
        }

        public Location Read(int id)
        {
            string sqlCommand = GetSqlCommand("Locations/Read");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var location = new Location((int)reader["Id"]);
                    location.Address1 = (string)reader["Address1"];
                    location.Address2 = ConvertDBVal<string>(reader["Address2"]);
                    location.City = (string)reader["City"];
                    location.State = (string)reader["State"];
                    location.Zip = ConvertDBVal<string>(reader["Zip"]);
                    location.Description = ConvertDBVal<string>(reader["Description"]);
                    return location;
                }
            }
            return null;
        }

        public bool Update(Location location)
        {
            string sqlCommand = GetSqlCommand("Locations/Update");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", location.Id);
            command.Parameters.AddWithValue("@Address1", location.Address1);
            command.Parameters.AddWithValue("@Address2", location.Address2);
            command.Parameters.AddWithValue("@City", location.City);
            command.Parameters.AddWithValue("@State", location.State);
            command.Parameters.AddWithValue("@Zip", location.Zip);
            command.Parameters.AddWithValue("@Description", location.Description);

            if (command.ExecuteNonQuery() > 0)
            {
                location.Status = ChangeStatus.None;
                return true;
            }
            return false;
        }

        public int UpdateAll(List<Location> locations)
        {
            int count = 0;
            for (int i = locations.Count - 1; i >= 0; i--)
            {
                var location = locations[i];
                bool updated = false;

                switch (location.Status)
                {
                    case ChangeStatus.New:
                        Create(location);
                        updated = true;
                        break;
                    case ChangeStatus.Changed:
                        updated = Update(location);
                        break;
                    case ChangeStatus.Deleted:
                        updated = Delete(location.Id);
                        locations.RemoveAt(i);
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
            string sqlCommand = GetSqlCommand("Locations/Delete");

            SqlCommand command = new SqlCommand(sqlCommand, m_connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ParentType", ParentType.Location);

            return command.ExecuteNonQuery() > 0;
        }

        public List<Location> SelectAll()
        {
            string sqlCommand = GetSqlCommand("Locations/SelectAll");
            SqlCommand command = new SqlCommand(sqlCommand, m_connection);

            var locations = new List<Location>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var location = new Location((int)reader["Id"]);
                    location.Address1 = (string)reader["Address1"];
                    location.Address2 = ConvertDBVal<string>(reader["Address2"]);
                    location.City = (string)reader["City"];
                    location.State = (string)reader["State"];
                    location.Zip = ConvertDBVal<string>(reader["Zip"]);
                    location.Description = ConvertDBVal<string>(reader["Description"]);
                    locations.Add(location);
                }
            }
            return locations;
        }

    }

}

using BookClub.Models;
using BookClub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Common
{

    public class ModelCache
    {

        public List<Book> Books { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Meeting> Meetings { get; private set; }
        public List<User> Users { get; private set; }

        public ModelCache(SqlConnection connection)
        {
            var bookService = new BookService(connection);
            Books = bookService.SelectAll();

            var locationService = new LocationService(connection);
            Locations = locationService.SelectAll();

            var meetingService = new MeetingService(connection);
            Meetings = meetingService.SelectAll();

            var userService = new UserService(connection);
            Users = userService.SelectAll();
        }

    }

}

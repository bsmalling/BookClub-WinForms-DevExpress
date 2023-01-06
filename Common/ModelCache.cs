using BookClub.Models;
using BookClub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Common
{

    public class ModelCache : IDisposable
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                Books = null;
                Locations = null;
                Meetings = null;
                Users = null;
            }
            // free native resources
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookClub.Models;
using BookClub.Services;

namespace BookClub
{
    public partial class MeetingForm : Form
    {

        public Meeting CurrentMeeting { get; set; }

        public MeetingForm()
        {
            InitializeComponent();
        }

        private void MeetingForm_Load(object sender, EventArgs e)
        {
            comboBoxEditBooks.Properties.Items.AddRange(MainForm.Cache.Books);
            comboBoxEditHosts.Properties.Items.AddRange(MainForm.Cache.Users);
            comboBoxEditLocations.Properties.Items.AddRange(MainForm.Cache.Locations);

            if (CurrentMeeting == null)
            {
                CurrentMeeting = new Meeting(-1)
                {
                    MeetTime = DateTime.Now.Date.AddDays(28) + new TimeSpan(19, 0, 0)
                };
            }
            else
            {
                comboBoxEditBooks.SelectedItem = CurrentMeeting.Book;
                comboBoxEditHosts.SelectedItem = CurrentMeeting.Host;
                comboBoxEditLocations.SelectedItem = CurrentMeeting.Location;
                memoEditDescription.Text = CurrentMeeting.Description;
            }
            dateEdit.DateTime = CurrentMeeting.MeetTime.Date;
            timeEdit.Time = CurrentMeeting.MeetTime;
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            CurrentMeeting.MeetTime = dateEdit.DateTime.Date +
                new TimeSpan(timeEdit.Time.Hour, timeEdit.Time.Minute, 0);
            CurrentMeeting.BookId = ((Book)comboBoxEditBooks.SelectedItem).Id;
            CurrentMeeting.HostId = ((User)comboBoxEditHosts.SelectedItem).Id;
            CurrentMeeting.LocationId = ((Location)comboBoxEditLocations.SelectedItem).Id;
            CurrentMeeting.Description = memoEditDescription.Text;

            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();

                using (var meetingService = new MeetingService(connection))
                    if (CurrentMeeting.Id == -1)
                        meetingService.Create(CurrentMeeting);
                    else
                        meetingService.Update(CurrentMeeting);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void simpleButtonNewBook_Click(object sender, EventArgs e)
        {
            using (BookForm form = new BookForm())
            {
                form.Text = "Add a new Book";
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    form.CurrentBook.Status = ChangeStatus.New;
                    MainForm.Cache.Books.Add(form.CurrentBook);
                    comboBoxEditBooks.Properties.Items.Add(form.CurrentBook);
                    comboBoxEditBooks.SelectedItem = form.CurrentBook;
                    CurrentMeeting.Book = form.CurrentBook;
                }
            }
        }

        private void simpleButtonNewLocation_Click(object sender, EventArgs e)
        {
            using (LocationForm form = new LocationForm())
            {
                form.Text = "Add a new Location";
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    form.CurrentLocation.Status = ChangeStatus.New;
                    MainForm.Cache.Locations.Add(form.CurrentLocation);
                    comboBoxEditLocations.Properties.Items.Add(form.CurrentLocation);
                    comboBoxEditLocations.SelectedItem = form.CurrentLocation;
                    CurrentMeeting.Location = form.CurrentLocation;
                }
            }
        }

    }

}

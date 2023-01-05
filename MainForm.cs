﻿using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookClub.Common;
using BookClub.Models;
using BookClub.Services;
using System.Data.SqlClient;
using System.IO;
using BookClub.Properties;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing.Text;
using DevExpress.XtraNavBar;

namespace BookClub
{

    public partial class MainForm : Form
    {

        public static User CurrentUser { get; private set; }
        public static ModelCache Cache { get; private set; }

        public MainForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;

            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();

                //var thumbnail = ImageFileToThumbnail(connection, "TeamOfRivals.jpg");

                Cache = new ModelCache(connection);
                gridControlBooks.DataSource = new BindingList<Book>(Cache.Books);
                gridControlLocations.DataSource = new BindingList<Location>(Cache.Locations);
                gridControlMeetings.DataSource = new BindingList<Meeting>(Cache.Meetings);
                gridControlUsers.DataSource = new BindingList<User>(Cache.Users);
            }

            if (CurrentUser.HasRole(UserRole.Power))
            {
                navBarItemUsers.Enabled = true;
                navBarItemSettings.Enabled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            xtraTabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            labelGreeting.Text = "Greetings, " + CurrentUser.FirstName + "!";

            UpdateNextMeeting();
        }

        private void UpdateNextMeeting()
        {
            var meeting = GetNextMeeting(Cache.Meetings);
            if (meeting == null)
            {
                panelControlNoMeetings.Visible = true;
                tablePanelNextMeeting.Visible = false;
            }
            else
            {
                panelControlNoMeetings.Visible = false;
                tablePanelNextMeeting.Visible = true;
                labelControlMeetingTime.Text = meeting.MeetTime.ToString("dddd, MMMM d, yyyy @ h:mm tt");
                labelControlHostname.Text = meeting.Host.FullName;
                labelControlBookTitle.Text = meeting.Book.Title;
                labelControlBookAuthor.Text = meeting.Book.Author;
                labelControlAddress1.Text = meeting.Location.Address1;

                var cityStateZip = meeting.Location.City + ", " +
                        meeting.Location.State + "  " + meeting.Location.Zip;
                if (meeting.Location.Address2 == null)
                {
                    labelControlAddress2.Text = cityStateZip;
                    labelControlCityStateZip.Text = string.Empty;
                }
                else
                {
                    labelControlAddress2.Text = meeting.Location.Address2;
                    labelControlCityStateZip.Text = cityStateZip;
                }
            }
        }

        private Meeting GetNextMeeting(List<Meeting> meetings)
        {
            Meeting nextMeeting = null;
            var minDate = DateTime.MaxValue;
            foreach (var meeting in meetings)
            {
                if (meeting.MeetTime > DateTime.Now && meeting.MeetTime < minDate)
                {
                    nextMeeting = meeting;
                    minDate = meeting.MeetTime;
                }
            }
            return nextMeeting;
        }

        //private Thumbnail ImageFileToThumbnail(SqlConnection connection, string filename)
        //{
        //    using (Stream bitmapStream = System.IO.File.Open("Images/" + filename, System.IO.FileMode.Open))
        //    {
        //        var thumbnail = new Thumbnail(-1);
        //        thumbnail.ImageObj = Image.FromStream(bitmapStream);
        //        var thumbnailService = new ThumbnailService(connection);
        //        return thumbnailService.Create(thumbnail);
        //    }
        //}

        private void navBarControlMain_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link == navBarItemHome.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageHome;
            }
            else if (e.Link == navBarItemMeetings.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageMeetings;
            }
            else if (e.Link == navBarItemLocations.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageLocations;
            }
            else if (e.Link == navBarItemBooks.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageBooks;
            }
            else if (e.Link == navBarItemUsers.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageUsers;
            }
            else if (e.Link == navBarItemSettings.Links[0])
            {
                xtraTabControlMain.SelectedTabPage = xtraTabPageSettings;
            }
        }

        #region BooksGrid

        private void gridControlBooks_Load(object sender, EventArgs e)
        {
            gridControlBooks.Tag = new GridTag();
        }

        private void gridControlBooks_Enter(object sender, EventArgs e)
        {
            ((GridTag)gridControlBooks.Tag).Updated = false;
        }

        private void gridViewBooks_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var books = gridControlBooks.DataSource as BindingList<Book>;
            books[e.RowHandle].Status = ChangeStatus.Changed;
            ((GridTag)gridControlBooks.Tag).Updated = true;
        }

        private void gridViewBooks_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var books = gridControlBooks.DataSource as BindingList<Book>;
            books[e.RowHandle].Status = ChangeStatus.Deleted;
            ((GridTag)gridControlBooks.Tag).Updated = true;
        }

        private void gridControlBooks_Leave(object sender, EventArgs e)
        {
            if (((GridTag)gridControlBooks.Tag).Updated)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    var books = gridControlBooks.DataSource as BindingList<Book>;
                    var bookService = new BookService(connection);

                    var list = books.ToList<Book>();
                    bookService.UpdateAll(list);
                    gridControlUsers.DataSource = new BindingList<Book>(list);
                }
                ((GridTag)gridControlBooks.Tag).Updated = false;
            }
        }

        private void gridViewBooks_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridViewBooks.GetSelectedRows()[0];
            var books = gridControlBooks.DataSource as BindingList<Book>;

            var form = new BookViewForm();
            form.CurrentBook = books[rowHandle];
            form.ShowDialog();
        }

        #endregion

        #region LocationsGrid

        private void gridControlLocations_Load(object sender, EventArgs e)
        {
            gridControlLocations.Tag = new GridTag();
        }

        private void gridControlLocations_Enter(object sender, EventArgs e)
        {
            ((GridTag)gridControlLocations.Tag).Updated = false;
        }

        private void gridViewLocations_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var locations = gridControlLocations.DataSource as BindingList<Location>;
            locations[e.RowHandle].Status = ChangeStatus.Changed;
            ((GridTag)gridControlLocations.Tag).Updated = true;
        }

        private void gridViewLocations_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var locations = gridControlLocations.DataSource as BindingList<Location>;
            locations[e.RowHandle].Status = ChangeStatus.Deleted;
            ((GridTag)gridControlLocations.Tag).Updated = true;
        }

        private void gridControlLocations_Leave(object sender, EventArgs e)
        {
            if (((GridTag)gridControlLocations.Tag).Updated)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    var locations = gridControlLocations.DataSource as BindingList<Location>;
                    var locationService = new LocationService(connection);

                    var list = locations.ToList<Location>();
                    locationService.UpdateAll(list);
                    gridControlLocations.DataSource = new BindingList<Location>(list);
                }
                ((GridTag)gridControlLocations.Tag).Updated = false;
            }
        }

        #endregion

        #region UsersGrid

        private void gridControlUsers_Load(object sender, EventArgs e)
        {
            gridControlUsers.Tag = new GridTag();
        }

        private void gridControlUsers_Enter(object sender, EventArgs e)
        {
            ((GridTag)gridControlUsers.Tag).Updated = false;
        }

        private void gridViewUsers_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var users = gridControlUsers.DataSource as BindingList<User>;
            users[e.RowHandle].Status = ChangeStatus.Changed;
            ((GridTag)gridControlUsers.Tag).Updated = true;
        }

        private void gridViewUsers_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var users = gridControlUsers.DataSource as BindingList<User>;
            users[e.RowHandle].Status = ChangeStatus.Deleted;
            ((GridTag)gridControlUsers.Tag).Updated = true;
        }

        private void gridControlUsers_Leave(object sender, EventArgs e)
        {
            if (((GridTag)gridControlUsers.Tag).Updated)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    var users = gridControlUsers.DataSource as BindingList<User>;
                    var userService = new UserService(connection);

                    var list = users.ToList<User>();
                    userService.UpdateAll(list);
                    gridControlUsers.DataSource = new BindingList<User>(list);
                }
                ((GridTag)gridControlUsers.Tag).Updated = false;
            }
        }

        private void gridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridViewUsers.GetSelectedRows()[0];
            var users = gridControlUsers.DataSource as BindingList<User>;
            showEditUserDialog(users[rowHandle]);
        }

        private void gridViewUsers_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                var users = view.DataSource as BindingList<User>;
                var user = users[e.HitInfo.RowHandle];

                e.Menu.Items.Clear();
                var items = new DXMenuItem[]
                {
                    new DXMenuItem("Edit user...", new EventHandler(OnEditUser)),
                    new DXMenuItem("Add a new user...", new EventHandler(OnCreateUser)),
                    new DXMenuItem("Delete user", new EventHandler(OnDeleteUser))
                };
                foreach (var item in items)
                {
                    item.Tag = user;
                    e.Menu.Items.Add(item);
                }
            }
        }

        private void OnEditUser(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var user = item.Tag as User;
            showEditUserDialog(user);
        }

        private void OnCreateUser(object sender, EventArgs e)
        {
            showAddUserDialog();
        }

        private void OnDeleteUser(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var user = item.Tag as User;

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Please verify!",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();

                    var userService = new UserService(connection);
                    userService.Delete(user.Id);
                }
                gridViewUsers.DeleteSelectedRows();
                Cache.Users.Remove(user);

                var bindingList = gridViewUsers.DataSource as BindingList<User>;
                bindingList.Remove(user);
            }
        }

        private void showAddUserDialog()
        {
            UserForm form = new UserForm();
            form.Text = "Add a User";
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cache.Users.Add(form.CurrentUser);
                gridViewUsers.LayoutChanged();
            }
        }

        private void showEditUserDialog(User user)
        {
            UserForm form = new UserForm();
            form.Text = "Edit User";
            form.CurrentUser = user;
            if (form.ShowDialog() == DialogResult.OK)
            {
                gridViewUsers.UpdateCurrentRow();
            }
        }

        #endregion

        #region MeetingsGrid

        private void gridControlMeetings_Load(object sender, EventArgs e)
        {
            gridControlMeetings.Tag = new GridTag();
        }

        private void gridControlMeetings_Enter(object sender, EventArgs e)
        {
            ((GridTag)gridControlMeetings.Tag).Updated = false;
        }

        private void gridViewMeetings_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var meetings = gridControlMeetings.DataSource as BindingList<Meeting>;
            meetings[e.RowHandle].Status = ChangeStatus.Changed;
            ((GridTag)gridControlMeetings.Tag).Updated = true;
        }

        private void gridViewMeetings_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            var meetings = gridControlMeetings.DataSource as BindingList<Meeting>;
            meetings[e.RowHandle].Status = ChangeStatus.Deleted;
            ((GridTag)gridControlMeetings.Tag).Updated = true;
        }

        private void gridControlMeetings_Leave(object sender, EventArgs e)
        {
            if (((GridTag)gridControlMeetings.Tag).Updated)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    var meetings = gridControlMeetings.DataSource as BindingList<Meeting>;
                    var meetingService = new MeetingService(connection);

                    var list = meetings.ToList<Meeting>();
                    meetingService.UpdateAll(list);
                    gridControlMeetings.DataSource = new BindingList<Meeting>(list);
                }
                ((GridTag)gridControlMeetings.Tag).Updated = false;
            }
        }

        private void simpleButtonAddMeeting_Click(object sender, EventArgs e)
        {
            showAddMeetingDialog();
        }

        private void gridViewMeetings_DoubleClick(object sender, EventArgs e)
        {
            int rowHandle = gridViewMeetings.GetSelectedRows()[0];
            var meetings = gridControlMeetings.DataSource as BindingList<Meeting>;
            showEditMeetingDialog(meetings[rowHandle]);
        }

        private void gridViewMeetings_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                var meetings = view.DataSource as BindingList<Meeting>;
                var meeting = meetings[e.HitInfo.RowHandle];

                e.Menu.Items.Clear();
                var items = new DXMenuItem[]
                {
                    new DXMenuItem("Edit meeting...", new EventHandler(OnEditMeeting)),
                    new DXMenuItem("Add a new meeting...", new EventHandler(OnCreateMeeting)),
                    new DXMenuItem("Add a comment...", new EventHandler(OnAddMeetingComment)),
                    new DXMenuItem("Add a recommendation...", new EventHandler(OnAddMeetingRecommendation)),
                    new DXMenuItem("Delete meeting", new EventHandler(OnDeleteMeeting))
                };
                foreach (var item in items)
                {
                    item.Tag = meeting;
                    e.Menu.Items.Add(item);
                }
            }
        }

        private void OnAddMeetingComment(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var meeting = item.Tag as Meeting;

            var form = new CommentForm();
            form.Text = "Add a Comment";
            if (form.ShowDialog() == DialogResult.OK)
            {
                var comment = form.CurrentComment;
                meeting.AddComment(comment);
            }
        }

        private void OnAddMeetingRecommendation(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var meeting = item.Tag as Meeting;

            var form = new RecommendationForm();
            form.Text = "Add a Recommendation";
            if (form.ShowDialog() == DialogResult.OK)
            {
                // TODO: To be completed...
            }
        }

        private void OnEditMeeting(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var meeting = item.Tag as Meeting;
            showEditMeetingDialog(meeting);
        }

        private void OnCreateMeeting(object sender, EventArgs e)
        {
            showAddMeetingDialog();
        }

        private void OnDeleteMeeting(object sender, EventArgs e)
        {
            var item = sender as DXMenuItem;
            var meeting = item.Tag as Meeting;

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this meeting?",
                "Please verify!",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();

                    var meetingService = new MeetingService(connection);
                    meetingService.Delete(meeting.Id);
                }
                gridViewMeetings.DeleteSelectedRows();
                Cache.Meetings.Remove(meeting);

                var bindingList = gridViewMeetings.DataSource as BindingList<Meeting>;
                bindingList.Remove(meeting);
                UpdateNextMeeting();
            }
        }

        private void showAddMeetingDialog()
        {
            var form = new MeetingForm();
            form.Text = "Add a Meeting";
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cache.Meetings.Add(form.CurrentMeeting);
                gridViewMeetings.LayoutChanged();
                UpdateNextMeeting();
            }
        }

        private void showEditMeetingDialog(Meeting meeting)
        {
            var form = new MeetingForm();
            form.Text = "Edit Meeting";
            form.CurrentMeeting = meeting;
            if (form.ShowDialog() == DialogResult.OK)
            {
                gridViewMeetings.UpdateCurrentRow();
                UpdateNextMeeting();
            }
        }

        #endregion

    }

}
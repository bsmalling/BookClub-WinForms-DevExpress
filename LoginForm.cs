using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

using BookClub.Models;
using BookClub.Services;

namespace BookClub
{
    public partial class LoginForm : Form
    {

        public string Username { get; private set; }
        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            username = "brad"; // TODO: Remove me!
            password = "asdf"; // TODO: Remove me!

            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();
                var userService = new UserService(connection);
                var unverifiedUser = userService.GetByUsername(username);
                if (unverifiedUser != null && unverifiedUser.HasRole(UserRole.User))
                {
                    if (unverifiedUser.IsCorrectPassword(username, password))
                    {
                        labelInvalidLogin.Visible = false;
                        DialogResult = DialogResult.OK;
                        CurrentUser = unverifiedUser;
                        Close();
                        return;
                    }
                }
            }
            labelInvalidLogin.Visible = true;
            CurrentUser = null;
        }

    }
}

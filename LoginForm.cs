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

        private int m_loginAttempts = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_loginAttempts += 1;
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            // username = "brad"; // TODO: Remove me! Is for speeding up debugging.
            // password = "asdf"; // TODO: Remove me! Is for speeding up debugging.

            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();
                using (var userService = new UserService(connection))
                {
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
            }

            labelInvalidLogin.Visible = true;
            textBoxPassword.Focus();
            textBoxPassword.Select(0, textBoxPassword.Text.Length);

            if (m_loginAttempts >= 3)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            CurrentUser = null;
        }

    }

}

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

namespace BookClub
{

    public partial class UserForm : Form
    {

        public User CurrentUser { get; set; }
        public bool ShowPassword { get; set; }

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (ShowPassword)
                EnablePasswordControls(true);
            else
                EnablePasswordControls(false);

            comboBoxEditRole.Properties.Items.AddRange(Enum.GetNames(typeof(UserRole)));
            comboBoxEditRole.SelectedItem = "User";

            if (!MainForm.CurrentUser.Equals(CurrentUser))
            {
                if (MainForm.CurrentUser.HasRole(UserRole.Admin))
                    EnablePasswordReset(true);
                else if (MainForm.CurrentUser.HasRole(UserRole.Power) && CurrentUser.Role < UserRole.Power)
                    EnablePasswordReset(true);
            }
            else
            {
                EnablePasswordControls(true);
                labelControlOldPassword.Enabled = true;
                textEditOldPassword.Enabled = true;
            }
        }

        private void EnablePasswordReset(bool enabled)
        {
            comboBoxEditRole.Enabled = enabled;
            checkEditReset.Enabled = enabled;
            EnablePasswordControls(!checkEditReset.Checked);
        }

        private void EnablePasswordControls(bool enabled)
        {
            labelControlPassword.Enabled = enabled;
            labelControlConfirm.Enabled = enabled;
            textEditPassword.Enabled = enabled;
            textEditConfirm.Enabled = enabled;
        }

        private void checkEditReset_CheckedChanged(object sender, EventArgs e)
        {  
            if (checkEditReset.Checked)
                EnablePasswordControls(true);
            else
                EnablePasswordControls(false);
        }

    }

}

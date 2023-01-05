namespace BookClub
{
    partial class MeetingViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControlDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLocation = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHost = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBook = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMeetingTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControlDescription
            // 
            this.labelControlDescription.Location = new System.Drawing.Point(8, 143);
            this.labelControlDescription.Name = "labelControlDescription";
            this.labelControlDescription.Size = new System.Drawing.Size(57, 13);
            this.labelControlDescription.TabIndex = 16;
            this.labelControlDescription.Text = "Description:";
            // 
            // labelControlLocation
            // 
            this.labelControlLocation.Location = new System.Drawing.Point(21, 108);
            this.labelControlLocation.Name = "labelControlLocation";
            this.labelControlLocation.Size = new System.Drawing.Size(44, 13);
            this.labelControlLocation.TabIndex = 15;
            this.labelControlLocation.Text = "Location:";
            // 
            // labelControlHost
            // 
            this.labelControlHost.Location = new System.Drawing.Point(39, 74);
            this.labelControlHost.Name = "labelControlHost";
            this.labelControlHost.Size = new System.Drawing.Size(26, 13);
            this.labelControlHost.TabIndex = 14;
            this.labelControlHost.Text = "Host:";
            // 
            // labelControlBook
            // 
            this.labelControlBook.Location = new System.Drawing.Point(38, 45);
            this.labelControlBook.Name = "labelControlBook";
            this.labelControlBook.Size = new System.Drawing.Size(27, 13);
            this.labelControlBook.TabIndex = 13;
            this.labelControlBook.Text = "Book:";
            // 
            // labelControlMeetingTime
            // 
            this.labelControlMeetingTime.Location = new System.Drawing.Point(12, 12);
            this.labelControlMeetingTime.Name = "labelControlMeetingTime";
            this.labelControlMeetingTime.Size = new System.Drawing.Size(53, 13);
            this.labelControlMeetingTime.TabIndex = 12;
            this.labelControlMeetingTime.Text = "Date/Time:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 226);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Recommendations:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Comments:";
            // 
            // MeetingViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControlDescription);
            this.Controls.Add(this.labelControlLocation);
            this.Controls.Add(this.labelControlHost);
            this.Controls.Add(this.labelControlBook);
            this.Controls.Add(this.labelControlMeetingTime);
            this.Name = "MeetingViewForm";
            this.Text = "Meeting Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlDescription;
        private DevExpress.XtraEditors.LabelControl labelControlLocation;
        private DevExpress.XtraEditors.LabelControl labelControlHost;
        private DevExpress.XtraEditors.LabelControl labelControlBook;
        private DevExpress.XtraEditors.LabelControl labelControlMeetingTime;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
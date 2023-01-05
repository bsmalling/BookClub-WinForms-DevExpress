namespace BookClub
{
    partial class MeetingForm
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
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlMeetingTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBook = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHost = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLocation = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonNewBook = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonNewLocation = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlDescription = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditLocations = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditHosts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditBooks = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLocations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHosts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBooks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(283, 261);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 14;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonOK.Appearance.Options.UseFont = true;
            this.simpleButtonOK.Location = new System.Drawing.Point(364, 261);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 13;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // labelControlMeetingTime
            // 
            this.labelControlMeetingTime.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlMeetingTime.Appearance.Options.UseFont = true;
            this.labelControlMeetingTime.Location = new System.Drawing.Point(13, 12);
            this.labelControlMeetingTime.Name = "labelControlMeetingTime";
            this.labelControlMeetingTime.Size = new System.Drawing.Size(64, 13);
            this.labelControlMeetingTime.TabIndex = 0;
            this.labelControlMeetingTime.Text = "Date/Time:";
            // 
            // labelControlBook
            // 
            this.labelControlBook.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlBook.Appearance.Options.UseFont = true;
            this.labelControlBook.Location = new System.Drawing.Point(45, 46);
            this.labelControlBook.Name = "labelControlBook";
            this.labelControlBook.Size = new System.Drawing.Size(31, 13);
            this.labelControlBook.TabIndex = 3;
            this.labelControlBook.Text = "Book:";
            // 
            // labelControlHost
            // 
            this.labelControlHost.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlHost.Appearance.Options.UseFont = true;
            this.labelControlHost.Location = new System.Drawing.Point(47, 75);
            this.labelControlHost.Name = "labelControlHost";
            this.labelControlHost.Size = new System.Drawing.Size(29, 13);
            this.labelControlHost.TabIndex = 6;
            this.labelControlHost.Text = "Host:";
            // 
            // labelControlLocation
            // 
            this.labelControlLocation.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControlLocation.Appearance.Options.UseFont = true;
            this.labelControlLocation.Location = new System.Drawing.Point(26, 109);
            this.labelControlLocation.Name = "labelControlLocation";
            this.labelControlLocation.Size = new System.Drawing.Size(51, 13);
            this.labelControlLocation.TabIndex = 8;
            this.labelControlLocation.Text = "Location:";
            // 
            // simpleButtonNewBook
            // 
            this.simpleButtonNewBook.Location = new System.Drawing.Point(327, 41);
            this.simpleButtonNewBook.Name = "simpleButtonNewBook";
            this.simpleButtonNewBook.Size = new System.Drawing.Size(112, 23);
            this.simpleButtonNewBook.TabIndex = 5;
            this.simpleButtonNewBook.Text = "Add a new Book...";
            this.simpleButtonNewBook.Click += new System.EventHandler(this.simpleButtonNewBook_Click);
            // 
            // simpleButtonNewLocation
            // 
            this.simpleButtonNewLocation.Location = new System.Drawing.Point(327, 104);
            this.simpleButtonNewLocation.Name = "simpleButtonNewLocation";
            this.simpleButtonNewLocation.Size = new System.Drawing.Size(112, 23);
            this.simpleButtonNewLocation.TabIndex = 10;
            this.simpleButtonNewLocation.Text = "Add a Location...";
            this.simpleButtonNewLocation.Click += new System.EventHandler(this.simpleButtonNewLocation_Click);
            // 
            // labelControlDescription
            // 
            this.labelControlDescription.Location = new System.Drawing.Point(19, 144);
            this.labelControlDescription.Name = "labelControlDescription";
            this.labelControlDescription.Size = new System.Drawing.Size(57, 13);
            this.labelControlDescription.TabIndex = 11;
            this.labelControlDescription.Text = "Description:";
            // 
            // comboBoxEditLocations
            // 
            this.comboBoxEditLocations.Location = new System.Drawing.Point(83, 106);
            this.comboBoxEditLocations.Name = "comboBoxEditLocations";
            this.comboBoxEditLocations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLocations.Size = new System.Drawing.Size(220, 20);
            this.comboBoxEditLocations.TabIndex = 9;
            // 
            // comboBoxEditHosts
            // 
            this.comboBoxEditHosts.Location = new System.Drawing.Point(83, 72);
            this.comboBoxEditHosts.Name = "comboBoxEditHosts";
            this.comboBoxEditHosts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditHosts.Size = new System.Drawing.Size(220, 20);
            this.comboBoxEditHosts.TabIndex = 7;
            // 
            // comboBoxEditBooks
            // 
            this.comboBoxEditBooks.Location = new System.Drawing.Point(82, 43);
            this.comboBoxEditBooks.Name = "comboBoxEditBooks";
            this.comboBoxEditBooks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBooks.Size = new System.Drawing.Size(221, 20);
            this.comboBoxEditBooks.TabIndex = 4;
            // 
            // timeEdit
            // 
            this.timeEdit.EditValue = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            this.timeEdit.Location = new System.Drawing.Point(203, 13);
            this.timeEdit.Name = "timeEdit";
            this.timeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit.Size = new System.Drawing.Size(100, 20);
            this.timeEdit.TabIndex = 2;
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(83, 13);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(114, 20);
            this.dateEdit.TabIndex = 1;
            // 
            // memoEditDescription
            // 
            this.memoEditDescription.Location = new System.Drawing.Point(82, 143);
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.MaxLength = 500;
            this.memoEditDescription.Size = new System.Drawing.Size(357, 96);
            this.memoEditDescription.TabIndex = 12;
            // 
            // MeetingForm
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(461, 300);
            this.Controls.Add(this.comboBoxEditLocations);
            this.Controls.Add(this.comboBoxEditHosts);
            this.Controls.Add(this.comboBoxEditBooks);
            this.Controls.Add(this.timeEdit);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.memoEditDescription);
            this.Controls.Add(this.labelControlDescription);
            this.Controls.Add(this.simpleButtonNewLocation);
            this.Controls.Add(this.simpleButtonNewBook);
            this.Controls.Add(this.labelControlLocation);
            this.Controls.Add(this.labelControlHost);
            this.Controls.Add(this.labelControlBook);
            this.Controls.Add(this.labelControlMeetingTime);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.simpleButtonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeetingForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MeetingForm";
            this.Load += new System.EventHandler(this.MeetingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLocations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHosts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBooks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.LabelControl labelControlMeetingTime;
        private DevExpress.XtraEditors.LabelControl labelControlBook;
        private DevExpress.XtraEditors.LabelControl labelControlHost;
        private DevExpress.XtraEditors.LabelControl labelControlLocation;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNewBook;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNewLocation;
        private DevExpress.XtraEditors.LabelControl labelControlDescription;
        private DevExpress.XtraEditors.MemoEdit memoEditDescription;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.TimeEdit timeEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditHosts;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLocations;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBooks;
    }
}
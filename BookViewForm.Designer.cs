namespace BookClub
{
    partial class BookViewForm
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
            this.components = new System.ComponentModel.Container();
            this.labelControlTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAuthor = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPublishedValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControlISBNValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControlASINValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPagesValue = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.gridControlComments = new DevExpress.XtraGrid.GridControl();
            this.gridViewComments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.pictureEditCover = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditCover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.labelControlTitle.Appearance.Options.UseFont = true;
            this.labelControlTitle.Appearance.Options.UseTextOptions = true;
            this.labelControlTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlTitle.Location = new System.Drawing.Point(77, 12);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(711, 36);
            this.labelControlTitle.TabIndex = 0;
            this.labelControlTitle.Text = "Title";
            // 
            // labelControlAuthor
            // 
            this.labelControlAuthor.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.labelControlAuthor.Appearance.Options.UseFont = true;
            this.labelControlAuthor.Appearance.Options.UseTextOptions = true;
            this.labelControlAuthor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlAuthor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlAuthor.Location = new System.Drawing.Point(77, 54);
            this.labelControlAuthor.Name = "labelControlAuthor";
            this.labelControlAuthor.Size = new System.Drawing.Size(711, 23);
            this.labelControlAuthor.TabIndex = 1;
            this.labelControlAuthor.Text = "by Author";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Pages:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(184, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ISBN:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(408, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "ASIN:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(603, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Published:";
            // 
            // labelControlPublishedValue
            // 
            this.labelControlPublishedValue.Location = new System.Drawing.Point(658, 109);
            this.labelControlPublishedValue.Name = "labelControlPublishedValue";
            this.labelControlPublishedValue.Size = new System.Drawing.Size(79, 13);
            this.labelControlPublishedValue.TabIndex = 7;
            this.labelControlPublishedValue.Text = "January 1, 2023";
            // 
            // labelControlISBNValue
            // 
            this.labelControlISBNValue.Location = new System.Drawing.Point(217, 109);
            this.labelControlISBNValue.Name = "labelControlISBNValue";
            this.labelControlISBNValue.Size = new System.Drawing.Size(95, 13);
            this.labelControlISBNValue.TabIndex = 8;
            this.labelControlISBNValue.Text = "NNN-NNNNNNNNNN";
            // 
            // labelControlASINValue
            // 
            this.labelControlASINValue.Location = new System.Drawing.Point(442, 109);
            this.labelControlASINValue.Name = "labelControlASINValue";
            this.labelControlASINValue.Size = new System.Drawing.Size(60, 13);
            this.labelControlASINValue.TabIndex = 9;
            this.labelControlASINValue.Text = "BXXXXXXXXX";
            // 
            // labelControlPagesValue
            // 
            this.labelControlPagesValue.Location = new System.Drawing.Point(53, 109);
            this.labelControlPagesValue.Name = "labelControlPagesValue";
            this.labelControlPagesValue.Size = new System.Drawing.Size(28, 13);
            this.labelControlPagesValue.TabIndex = 10;
            this.labelControlPagesValue.Text = "1,000";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 83);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(797, 20);
            this.separatorControl1.TabIndex = 11;
            // 
            // gridControlComments
            // 
            this.gridControlComments.DataSource = typeof(BookClub.Models.Comment);
            this.gridControlComments.Location = new System.Drawing.Point(12, 128);
            this.gridControlComments.MainView = this.gridViewComments;
            this.gridControlComments.Name = "gridControlComments";
            this.gridControlComments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControlComments.Size = new System.Drawing.Size(776, 310);
            this.gridControlComments.TabIndex = 13;
            this.gridControlComments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComments});
            // 
            // gridViewComments
            // 
            this.gridViewComments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCreated,
            this.colUser,
            this.colText});
            this.gridViewComments.GridControl = this.gridControlComments;
            this.gridViewComments.Name = "gridViewComments";
            // 
            // colCreated
            // 
            this.colCreated.Caption = "Date";
            this.colCreated.DisplayFormat.FormatString = "MM/dd/yyyy h:mm tt";
            this.colCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.OptionsColumn.AllowEdit = false;
            this.colCreated.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCreated.OptionsColumn.AllowMove = false;
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 0;
            this.colCreated.Width = 119;
            // 
            // colUser
            // 
            this.colUser.Caption = "User";
            this.colUser.FieldName = "User";
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.AllowEdit = false;
            this.colUser.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUser.OptionsColumn.AllowMove = false;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 1;
            this.colUser.Width = 85;
            // 
            // colText
            // 
            this.colText.AppearanceCell.Options.UseTextOptions = true;
            this.colText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colText.Caption = "Comment";
            this.colText.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.OptionsColumn.AllowEdit = false;
            this.colText.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colText.OptionsColumn.AllowMove = false;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 2;
            this.colText.Width = 481;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // pictureEditCover
            // 
            this.pictureEditCover.Location = new System.Drawing.Point(12, 5);
            this.pictureEditCover.Name = "pictureEditCover";
            this.pictureEditCover.Properties.AllowFocused = false;
            this.pictureEditCover.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEditCover.Properties.ReadOnly = true;
            this.pictureEditCover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditCover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditCover.Size = new System.Drawing.Size(60, 84);
            this.pictureEditCover.TabIndex = 14;
            // 
            // BookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureEditCover);
            this.Controls.Add(this.gridControlComments);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControlPagesValue);
            this.Controls.Add(this.labelControlASINValue);
            this.Controls.Add(this.labelControlISBNValue);
            this.Controls.Add(this.labelControlPublishedValue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControlAuthor);
            this.Controls.Add(this.labelControlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookViewForm";
            this.ShowInTaskbar = false;
            this.Text = "BookViewForm";
            this.Load += new System.EventHandler(this.BookViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditCover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlTitle;
        private DevExpress.XtraEditors.LabelControl labelControlAuthor;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControlPublishedValue;
        private DevExpress.XtraEditors.LabelControl labelControlISBNValue;
        private DevExpress.XtraEditors.LabelControl labelControlASINValue;
        private DevExpress.XtraEditors.LabelControl labelControlPagesValue;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraGrid.GridControl gridControlComments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComments;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEditCover;
    }
}
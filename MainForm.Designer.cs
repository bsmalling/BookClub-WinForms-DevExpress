namespace BookClub
{
    partial class MainForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridViewMeetingRecs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMeetings = new DevExpress.XtraGrid.GridControl();
            this.gridViewMeetingComs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnComDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewMeetings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMeetTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControlMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemHome = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemMeetings = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemLocations = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemBooks = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSettings = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageHome = new DevExpress.XtraTab.XtraTabPage();
            this.xtraScrollableControlMain = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControlNoMeetings = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonAddMeeting = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlNoMeetings = new DevExpress.XtraEditors.LabelControl();
            this.tablePanelNextMeeting = new DevExpress.Utils.Layout.TablePanel();
            this.labelControlAuthor = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCityStateZip = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAddress2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAddress1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHostname = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBookAuthor = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMeetingTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHost = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLocation = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBookTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControlBook = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNextMeeting = new DevExpress.XtraEditors.LabelControl();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraTabPageMeetings = new DevExpress.XtraTab.XtraTabPage();
            this.panelControlMeetingComments = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabPageLocations = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlLocations = new DevExpress.XtraGrid.GridControl();
            this.gridViewLocations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageBooks = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlBooks = new DevExpress.XtraGrid.GridControl();
            this.gridViewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThumbnail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.xtraTabPageUsers = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAboutMe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageSettings = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetingRecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMeetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetingComs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageHome.SuspendLayout();
            this.xtraScrollableControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNoMeetings)).BeginInit();
            this.panelControlNoMeetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelNextMeeting)).BeginInit();
            this.tablePanelNextMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.xtraTabPageMeetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMeetingComments)).BeginInit();
            this.xtraTabPageLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocations)).BeginInit();
            this.xtraTabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.xtraTabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMeetingRecs
            // 
            this.gridViewMeetingRecs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBook,
            this.gridColumnUser,
            this.gridColumnCreated});
            this.gridViewMeetingRecs.GridControl = this.gridControlMeetings;
            this.gridViewMeetingRecs.Name = "gridViewMeetingRecs";
            this.gridViewMeetingRecs.ViewCaption = "Book Recommendations";
            // 
            // gridColumnBook
            // 
            this.gridColumnBook.Caption = "Book";
            this.gridColumnBook.FieldName = "Book";
            this.gridColumnBook.Name = "gridColumnBook";
            this.gridColumnBook.Visible = true;
            this.gridColumnBook.VisibleIndex = 0;
            this.gridColumnBook.Width = 417;
            // 
            // gridColumnUser
            // 
            this.gridColumnUser.Caption = "User";
            this.gridColumnUser.FieldName = "User";
            this.gridColumnUser.Name = "gridColumnUser";
            this.gridColumnUser.Visible = true;
            this.gridColumnUser.VisibleIndex = 1;
            this.gridColumnUser.Width = 126;
            // 
            // gridColumnCreated
            // 
            this.gridColumnCreated.Caption = "Date";
            this.gridColumnCreated.DisplayFormat.FormatString = "MM/dd/yyyy h:mm tt";
            this.gridColumnCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnCreated.FieldName = "Created";
            this.gridColumnCreated.Name = "gridColumnCreated";
            this.gridColumnCreated.Visible = true;
            this.gridColumnCreated.VisibleIndex = 2;
            this.gridColumnCreated.Width = 142;
            // 
            // gridControlMeetings
            // 
            this.gridControlMeetings.DataSource = typeof(BookClub.Models.Meeting);
            this.gridControlMeetings.Dock = System.Windows.Forms.DockStyle.Right;
            gridLevelNode1.LevelTemplate = this.gridViewMeetingRecs;
            gridLevelNode1.RelationName = "Recommendations";
            gridLevelNode2.LevelTemplate = this.gridViewMeetingComs;
            gridLevelNode2.RelationName = "Comments";
            this.gridControlMeetings.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlMeetings.Location = new System.Drawing.Point(0, 0);
            this.gridControlMeetings.MainView = this.gridViewMeetings;
            this.gridControlMeetings.Name = "gridControlMeetings";
            this.gridControlMeetings.Size = new System.Drawing.Size(897, 616);
            this.gridControlMeetings.TabIndex = 0;
            this.gridControlMeetings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMeetingComs,
            this.gridViewMeetings,
            this.gridViewMeetingRecs});
            this.gridControlMeetings.Load += new System.EventHandler(this.gridControlMeetings_Load);
            this.gridControlMeetings.Enter += new System.EventHandler(this.gridControlMeetings_Enter);
            this.gridControlMeetings.Leave += new System.EventHandler(this.gridControlMeetings_Leave);
            // 
            // gridViewMeetingComs
            // 
            this.gridViewMeetingComs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnComDate,
            this.gridColumnComText,
            this.gridColumnComUser});
            this.gridViewMeetingComs.GridControl = this.gridControlMeetings;
            this.gridViewMeetingComs.Name = "gridViewMeetingComs";
            // 
            // gridColumnComDate
            // 
            this.gridColumnComDate.Caption = "Date";
            this.gridColumnComDate.DisplayFormat.FormatString = "MM/dd/yyyy h:mm tt";
            this.gridColumnComDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnComDate.FieldName = "Created";
            this.gridColumnComDate.Name = "gridColumnComDate";
            this.gridColumnComDate.Visible = true;
            this.gridColumnComDate.VisibleIndex = 0;
            this.gridColumnComDate.Width = 119;
            // 
            // gridColumnComText
            // 
            this.gridColumnComText.Caption = "Text";
            this.gridColumnComText.FieldName = "Text";
            this.gridColumnComText.Name = "gridColumnComText";
            this.gridColumnComText.Visible = true;
            this.gridColumnComText.VisibleIndex = 1;
            this.gridColumnComText.Width = 440;
            // 
            // gridColumnComUser
            // 
            this.gridColumnComUser.Caption = "User";
            this.gridColumnComUser.FieldName = "User";
            this.gridColumnComUser.Name = "gridColumnComUser";
            this.gridColumnComUser.Visible = true;
            this.gridColumnComUser.VisibleIndex = 2;
            this.gridColumnComUser.Width = 126;
            // 
            // gridViewMeetings
            // 
            this.gridViewMeetings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMeetTime,
            this.colBook,
            this.colHost,
            this.colLocation,
            this.colDescription2});
            this.gridViewMeetings.GridControl = this.gridControlMeetings;
            this.gridViewMeetings.Name = "gridViewMeetings";
            this.gridViewMeetings.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewMeetings_PopupMenuShowing);
            this.gridViewMeetings.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewMeetings_RowDeleted);
            this.gridViewMeetings.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewMeetings_RowUpdated);
            this.gridViewMeetings.DoubleClick += new System.EventHandler(this.gridViewMeetings_DoubleClick);
            // 
            // colMeetTime
            // 
            this.colMeetTime.Caption = "Meeting Time";
            this.colMeetTime.DisplayFormat.FormatString = "MM/dd/yyyy h:mm tt";
            this.colMeetTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMeetTime.FieldName = "MeetTime";
            this.colMeetTime.Name = "colMeetTime";
            this.colMeetTime.Visible = true;
            this.colMeetTime.VisibleIndex = 0;
            this.colMeetTime.Width = 168;
            // 
            // colBook
            // 
            this.colBook.Caption = "Book";
            this.colBook.FieldName = "Book.Title";
            this.colBook.Name = "colBook";
            this.colBook.OptionsColumn.AllowEdit = false;
            this.colBook.OptionsColumn.ReadOnly = true;
            this.colBook.Visible = true;
            this.colBook.VisibleIndex = 1;
            this.colBook.Width = 171;
            // 
            // colHost
            // 
            this.colHost.Caption = "Host";
            this.colHost.FieldName = "Host.FullName";
            this.colHost.Name = "colHost";
            this.colHost.OptionsColumn.AllowEdit = false;
            this.colHost.OptionsColumn.ReadOnly = true;
            this.colHost.Visible = true;
            this.colHost.VisibleIndex = 2;
            this.colHost.Width = 172;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Location";
            this.colLocation.FieldName = "Location.Address1";
            this.colLocation.Name = "colLocation";
            this.colLocation.OptionsColumn.AllowEdit = false;
            this.colLocation.OptionsColumn.ReadOnly = true;
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 3;
            this.colLocation.Width = 172;
            // 
            // colDescription2
            // 
            this.colDescription2.FieldName = "Description";
            this.colDescription2.Name = "colDescription2";
            this.colDescription2.Visible = true;
            this.colDescription2.VisibleIndex = 4;
            this.colDescription2.Width = 183;
            // 
            // navBarControlMain
            // 
            this.navBarControlMain.ActiveGroup = this.navBarGroup1;
            this.navBarControlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControlMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemHome,
            this.navBarItemMeetings,
            this.navBarItemLocations,
            this.navBarItemBooks,
            this.navBarItemUsers,
            this.navBarItemSettings});
            this.navBarControlMain.Location = new System.Drawing.Point(0, 0);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControlMain.Size = new System.Drawing.Size(140, 641);
            this.navBarControlMain.TabIndex = 0;
            this.navBarControlMain.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlMain_LinkPressed);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Main";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemHome),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemMeetings),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemLocations),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemBooks)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemHome
            // 
            this.navBarItemHome.Caption = "Home";
            this.navBarItemHome.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemHome.ImageOptions.LargeImage")));
            this.navBarItemHome.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemHome.ImageOptions.SmallImage")));
            this.navBarItemHome.Name = "navBarItemHome";
            // 
            // navBarItemMeetings
            // 
            this.navBarItemMeetings.Caption = "Meetings";
            this.navBarItemMeetings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemMeetings.ImageOptions.LargeImage")));
            this.navBarItemMeetings.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemMeetings.ImageOptions.SmallImage")));
            this.navBarItemMeetings.Name = "navBarItemMeetings";
            // 
            // navBarItemLocations
            // 
            this.navBarItemLocations.Caption = "Locations";
            this.navBarItemLocations.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemLocations.ImageOptions.LargeImage")));
            this.navBarItemLocations.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemLocations.ImageOptions.SmallImage")));
            this.navBarItemLocations.Name = "navBarItemLocations";
            // 
            // navBarItemBooks
            // 
            this.navBarItemBooks.Caption = "Books";
            this.navBarItemBooks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemBooks.ImageOptions.LargeImage")));
            this.navBarItemBooks.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemBooks.ImageOptions.SmallImage")));
            this.navBarItemBooks.Name = "navBarItemBooks";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Admin";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemUsers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSettings)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemUsers
            // 
            this.navBarItemUsers.Caption = "Users";
            this.navBarItemUsers.Enabled = false;
            this.navBarItemUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemUsers.ImageOptions.LargeImage")));
            this.navBarItemUsers.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemUsers.ImageOptions.SmallImage")));
            this.navBarItemUsers.Name = "navBarItemUsers";
            // 
            // navBarItemSettings
            // 
            this.navBarItemSettings.Caption = "Settings";
            this.navBarItemSettings.Enabled = false;
            this.navBarItemSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemSettings.ImageOptions.LargeImage")));
            this.navBarItemSettings.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemSettings.ImageOptions.SmallImage")));
            this.navBarItemSettings.Name = "navBarItemSettings";
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlMain.Location = new System.Drawing.Point(140, 0);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageHome;
            this.xtraTabControlMain.Size = new System.Drawing.Size(899, 641);
            this.xtraTabControlMain.TabIndex = 1;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageHome,
            this.xtraTabPageMeetings,
            this.xtraTabPageLocations,
            this.xtraTabPageBooks,
            this.xtraTabPageUsers,
            this.xtraTabPageSettings});
            // 
            // xtraTabPageHome
            // 
            this.xtraTabPageHome.Controls.Add(this.xtraScrollableControlMain);
            this.xtraTabPageHome.Controls.Add(this.xtraScrollableControl1);
            this.xtraTabPageHome.Name = "xtraTabPageHome";
            this.xtraTabPageHome.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageHome.Text = "Home";
            // 
            // xtraScrollableControlMain
            // 
            this.xtraScrollableControlMain.Controls.Add(this.panelControlNoMeetings);
            this.xtraScrollableControlMain.Controls.Add(this.tablePanelNextMeeting);
            this.xtraScrollableControlMain.Controls.Add(this.labelGreeting);
            this.xtraScrollableControlMain.Controls.Add(this.pictureBoxLogo);
            this.xtraScrollableControlMain.Location = new System.Drawing.Point(3, 3);
            this.xtraScrollableControlMain.Name = "xtraScrollableControlMain";
            this.xtraScrollableControlMain.Size = new System.Drawing.Size(861, 586);
            this.xtraScrollableControlMain.TabIndex = 1;
            // 
            // panelControlNoMeetings
            // 
            this.panelControlNoMeetings.Controls.Add(this.simpleButtonAddMeeting);
            this.panelControlNoMeetings.Controls.Add(this.labelControlNoMeetings);
            this.panelControlNoMeetings.Location = new System.Drawing.Point(130, 159);
            this.panelControlNoMeetings.Name = "panelControlNoMeetings";
            this.panelControlNoMeetings.Size = new System.Drawing.Size(718, 90);
            this.panelControlNoMeetings.TabIndex = 5;
            // 
            // simpleButtonAddMeeting
            // 
            this.simpleButtonAddMeeting.Location = new System.Drawing.Point(279, 41);
            this.simpleButtonAddMeeting.Name = "simpleButtonAddMeeting";
            this.simpleButtonAddMeeting.Size = new System.Drawing.Size(130, 23);
            this.simpleButtonAddMeeting.TabIndex = 5;
            this.simpleButtonAddMeeting.Text = "Add a new Meeting...";
            this.simpleButtonAddMeeting.Click += new System.EventHandler(this.simpleButtonAddMeeting_Click);
            // 
            // labelControlNoMeetings
            // 
            this.labelControlNoMeetings.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNoMeetings.Appearance.Options.UseFont = true;
            this.labelControlNoMeetings.Location = new System.Drawing.Point(235, 19);
            this.labelControlNoMeetings.Name = "labelControlNoMeetings";
            this.labelControlNoMeetings.Size = new System.Drawing.Size(221, 19);
            this.labelControlNoMeetings.TabIndex = 4;
            this.labelControlNoMeetings.Text = "There are no upcoming meetings.";
            // 
            // tablePanelNextMeeting
            // 
            this.tablePanelNextMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelNextMeeting.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.08F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.92F)});
            this.tablePanelNextMeeting.Controls.Add(this.labelControlAuthor);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlCityStateZip);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlAddress2);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlAddress1);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlHostname);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlBookAuthor);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlMeetingTime);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlHost);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlLocation);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlBookTitle);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlBook);
            this.tablePanelNextMeeting.Controls.Add(this.labelControlNextMeeting);
            this.tablePanelNextMeeting.Location = new System.Drawing.Point(117, 191);
            this.tablePanelNextMeeting.Name = "tablePanelNextMeeting";
            this.tablePanelNextMeeting.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelNextMeeting.Size = new System.Drawing.Size(744, 230);
            this.tablePanelNextMeeting.TabIndex = 3;
            this.tablePanelNextMeeting.UseSkinIndents = true;
            // 
            // labelControlAuthor
            // 
            this.labelControlAuthor.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAuthor.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlAuthor, 0);
            this.labelControlAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlAuthor.Location = new System.Drawing.Point(13, 64);
            this.labelControlAuthor.Name = "labelControlAuthor";
            this.tablePanelNextMeeting.SetRow(this.labelControlAuthor, 2);
            this.labelControlAuthor.Size = new System.Drawing.Size(105, 22);
            this.labelControlAuthor.TabIndex = 11;
            this.labelControlAuthor.Text = "Author:";
            // 
            // labelControlCityStateZip
            // 
            this.labelControlCityStateZip.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCityStateZip.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlCityStateZip, 1);
            this.labelControlCityStateZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlCityStateZip.Location = new System.Drawing.Point(122, 168);
            this.labelControlCityStateZip.Name = "labelControlCityStateZip";
            this.tablePanelNextMeeting.SetRow(this.labelControlCityStateZip, 6);
            this.labelControlCityStateZip.Size = new System.Drawing.Size(609, 22);
            this.labelControlCityStateZip.TabIndex = 10;
            this.labelControlCityStateZip.Text = "City, State, Zip";
            // 
            // labelControlAddress2
            // 
            this.labelControlAddress2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAddress2.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlAddress2, 1);
            this.labelControlAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlAddress2.Location = new System.Drawing.Point(122, 142);
            this.labelControlAddress2.Name = "labelControlAddress2";
            this.tablePanelNextMeeting.SetRow(this.labelControlAddress2, 5);
            this.labelControlAddress2.Size = new System.Drawing.Size(609, 22);
            this.labelControlAddress2.TabIndex = 9;
            this.labelControlAddress2.Text = "Address2";
            // 
            // labelControlAddress1
            // 
            this.labelControlAddress1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAddress1.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlAddress1, 1);
            this.labelControlAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlAddress1.Location = new System.Drawing.Point(122, 116);
            this.labelControlAddress1.Name = "labelControlAddress1";
            this.tablePanelNextMeeting.SetRow(this.labelControlAddress1, 4);
            this.labelControlAddress1.Size = new System.Drawing.Size(609, 22);
            this.labelControlAddress1.TabIndex = 8;
            this.labelControlAddress1.Text = "Address1";
            // 
            // labelControlHostname
            // 
            this.labelControlHostname.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHostname.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlHostname, 1);
            this.labelControlHostname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlHostname.Location = new System.Drawing.Point(122, 90);
            this.labelControlHostname.Name = "labelControlHostname";
            this.tablePanelNextMeeting.SetRow(this.labelControlHostname, 3);
            this.labelControlHostname.Size = new System.Drawing.Size(609, 22);
            this.labelControlHostname.TabIndex = 7;
            this.labelControlHostname.Text = "Host";
            // 
            // labelControlBookAuthor
            // 
            this.labelControlBookAuthor.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBookAuthor.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlBookAuthor, 1);
            this.labelControlBookAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlBookAuthor.Location = new System.Drawing.Point(122, 64);
            this.labelControlBookAuthor.Name = "labelControlBookAuthor";
            this.tablePanelNextMeeting.SetRow(this.labelControlBookAuthor, 2);
            this.labelControlBookAuthor.Size = new System.Drawing.Size(609, 22);
            this.labelControlBookAuthor.TabIndex = 6;
            this.labelControlBookAuthor.Text = "Author";
            // 
            // labelControlMeetingTime
            // 
            this.labelControlMeetingTime.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlMeetingTime.Appearance.Options.UseFont = true;
            this.labelControlMeetingTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanelNextMeeting.SetColumn(this.labelControlMeetingTime, 1);
            this.labelControlMeetingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlMeetingTime.Location = new System.Drawing.Point(122, 12);
            this.labelControlMeetingTime.Name = "labelControlMeetingTime";
            this.tablePanelNextMeeting.SetRow(this.labelControlMeetingTime, 0);
            this.labelControlMeetingTime.Size = new System.Drawing.Size(609, 22);
            this.labelControlMeetingTime.TabIndex = 5;
            this.labelControlMeetingTime.Text = "Next Meeting Time";
            // 
            // labelControlHost
            // 
            this.labelControlHost.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHost.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlHost, 0);
            this.labelControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlHost.Location = new System.Drawing.Point(13, 90);
            this.labelControlHost.Name = "labelControlHost";
            this.tablePanelNextMeeting.SetRow(this.labelControlHost, 3);
            this.labelControlHost.Size = new System.Drawing.Size(105, 22);
            this.labelControlHost.TabIndex = 4;
            this.labelControlHost.Text = "Host:";
            // 
            // labelControlLocation
            // 
            this.labelControlLocation.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlLocation.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlLocation, 0);
            this.labelControlLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlLocation.Location = new System.Drawing.Point(13, 116);
            this.labelControlLocation.Name = "labelControlLocation";
            this.tablePanelNextMeeting.SetRow(this.labelControlLocation, 4);
            this.labelControlLocation.Size = new System.Drawing.Size(105, 22);
            this.labelControlLocation.TabIndex = 3;
            this.labelControlLocation.Text = "Location:";
            // 
            // labelControlBookTitle
            // 
            this.labelControlBookTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBookTitle.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlBookTitle, 1);
            this.labelControlBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlBookTitle.Location = new System.Drawing.Point(122, 38);
            this.labelControlBookTitle.Name = "labelControlBookTitle";
            this.tablePanelNextMeeting.SetRow(this.labelControlBookTitle, 1);
            this.labelControlBookTitle.Size = new System.Drawing.Size(609, 22);
            this.labelControlBookTitle.TabIndex = 2;
            this.labelControlBookTitle.Text = "Title";
            // 
            // labelControlBook
            // 
            this.labelControlBook.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBook.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlBook, 0);
            this.labelControlBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlBook.Location = new System.Drawing.Point(13, 38);
            this.labelControlBook.Name = "labelControlBook";
            this.tablePanelNextMeeting.SetRow(this.labelControlBook, 1);
            this.labelControlBook.Size = new System.Drawing.Size(105, 22);
            this.labelControlBook.TabIndex = 1;
            this.labelControlBook.Text = "Book:";
            // 
            // labelControlNextMeeting
            // 
            this.labelControlNextMeeting.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlNextMeeting.Appearance.Options.UseFont = true;
            this.tablePanelNextMeeting.SetColumn(this.labelControlNextMeeting, 0);
            this.labelControlNextMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControlNextMeeting.Location = new System.Drawing.Point(13, 12);
            this.labelControlNextMeeting.Name = "labelControlNextMeeting";
            this.tablePanelNextMeeting.SetRow(this.labelControlNextMeeting, 0);
            this.labelControlNextMeeting.Size = new System.Drawing.Size(105, 22);
            this.labelControlNextMeeting.TabIndex = 0;
            this.labelControlNextMeeting.Text = "Next Meeting:";
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(111, 61);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(221, 36);
            this.labelGreeting.TabIndex = 2;
            this.labelGreeting.Text = "Greetings, User!";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BookClub.Properties.Resources.bookclub;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 152);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // xtraTabPageMeetings
            // 
            this.xtraTabPageMeetings.Controls.Add(this.panelControlMeetingComments);
            this.xtraTabPageMeetings.Controls.Add(this.gridControlMeetings);
            this.xtraTabPageMeetings.Name = "xtraTabPageMeetings";
            this.xtraTabPageMeetings.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageMeetings.Text = "Meetings";
            // 
            // panelControlMeetingComments
            // 
            this.panelControlMeetingComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlMeetingComments.Location = new System.Drawing.Point(0, 0);
            this.panelControlMeetingComments.Name = "panelControlMeetingComments";
            this.panelControlMeetingComments.Size = new System.Drawing.Size(0, 616);
            this.panelControlMeetingComments.TabIndex = 2;
            // 
            // xtraTabPageLocations
            // 
            this.xtraTabPageLocations.Controls.Add(this.gridControlLocations);
            this.xtraTabPageLocations.Name = "xtraTabPageLocations";
            this.xtraTabPageLocations.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageLocations.Text = "Locations";
            // 
            // gridControlLocations
            // 
            this.gridControlLocations.DataSource = typeof(BookClub.Models.Location);
            this.gridControlLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLocations.Location = new System.Drawing.Point(0, 0);
            this.gridControlLocations.MainView = this.gridViewLocations;
            this.gridControlLocations.Name = "gridControlLocations";
            this.gridControlLocations.Size = new System.Drawing.Size(897, 616);
            this.gridControlLocations.TabIndex = 0;
            this.gridControlLocations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLocations});
            this.gridControlLocations.Load += new System.EventHandler(this.gridControlLocations_Load);
            this.gridControlLocations.Enter += new System.EventHandler(this.gridControlLocations_Enter);
            this.gridControlLocations.Leave += new System.EventHandler(this.gridControlLocations_Leave);
            // 
            // gridViewLocations
            // 
            this.gridViewLocations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddress1,
            this.colAddress2,
            this.colCity,
            this.colState,
            this.colZip,
            this.colDescription1});
            this.gridViewLocations.GridControl = this.gridControlLocations;
            this.gridViewLocations.Name = "gridViewLocations";
            this.gridViewLocations.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewLocations_RowDeleted);
            this.gridViewLocations.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewLocations_RowUpdated);
            // 
            // colAddress1
            // 
            this.colAddress1.FieldName = "Address1";
            this.colAddress1.Name = "colAddress1";
            this.colAddress1.Visible = true;
            this.colAddress1.VisibleIndex = 0;
            this.colAddress1.Width = 210;
            // 
            // colAddress2
            // 
            this.colAddress2.FieldName = "Address2";
            this.colAddress2.Name = "colAddress2";
            this.colAddress2.Visible = true;
            this.colAddress2.VisibleIndex = 1;
            this.colAddress2.Width = 94;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 2;
            this.colCity.Width = 79;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 3;
            this.colState.Width = 30;
            // 
            // colZip
            // 
            this.colZip.FieldName = "Zip";
            this.colZip.Name = "colZip";
            this.colZip.Visible = true;
            this.colZip.VisibleIndex = 4;
            this.colZip.Width = 64;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 5;
            this.colDescription1.Width = 208;
            // 
            // xtraTabPageBooks
            // 
            this.xtraTabPageBooks.Controls.Add(this.gridControlBooks);
            this.xtraTabPageBooks.Name = "xtraTabPageBooks";
            this.xtraTabPageBooks.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageBooks.Text = "Books";
            // 
            // gridControlBooks
            // 
            this.gridControlBooks.DataSource = typeof(BookClub.Models.Book);
            this.gridControlBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBooks.Location = new System.Drawing.Point(0, 0);
            this.gridControlBooks.MainView = this.gridViewBooks;
            this.gridControlBooks.Name = "gridControlBooks";
            this.gridControlBooks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControlBooks.Size = new System.Drawing.Size(897, 616);
            this.gridControlBooks.TabIndex = 0;
            this.gridControlBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBooks});
            this.gridControlBooks.Load += new System.EventHandler(this.gridControlBooks_Load);
            this.gridControlBooks.Enter += new System.EventHandler(this.gridControlBooks_Enter);
            this.gridControlBooks.Leave += new System.EventHandler(this.gridControlBooks_Leave);
            // 
            // gridViewBooks
            // 
            this.gridViewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThumbnail,
            this.colTitle,
            this.colAuthor,
            this.colPages,
            this.colPublished,
            this.colDescription});
            this.gridViewBooks.GridControl = this.gridControlBooks;
            this.gridViewBooks.Name = "gridViewBooks";
            this.gridViewBooks.OptionsView.RowAutoHeight = true;
            this.gridViewBooks.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTitle, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewBooks.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewBooks_RowDeleted);
            this.gridViewBooks.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewBooks_RowUpdated);
            this.gridViewBooks.DoubleClick += new System.EventHandler(this.gridViewBooks_DoubleClick);
            // 
            // colThumbnail
            // 
            this.colThumbnail.Caption = "Cover";
            this.colThumbnail.FieldName = "Thumbnail.ImageObj";
            this.colThumbnail.Name = "colThumbnail";
            this.colThumbnail.Visible = true;
            this.colThumbnail.VisibleIndex = 0;
            this.colThumbnail.Width = 62;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 124;
            // 
            // colAuthor
            // 
            this.colAuthor.FieldName = "Author";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 2;
            this.colAuthor.Width = 124;
            // 
            // colPages
            // 
            this.colPages.FieldName = "Pages";
            this.colPages.Name = "colPages";
            this.colPages.Visible = true;
            this.colPages.VisibleIndex = 3;
            this.colPages.Width = 58;
            // 
            // colPublished
            // 
            this.colPublished.FieldName = "Published";
            this.colPublished.Name = "colPublished";
            this.colPublished.Visible = true;
            this.colPublished.VisibleIndex = 4;
            this.colPublished.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceCell.Options.UseTextOptions = true;
            this.colDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDescription.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 227;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // xtraTabPageUsers
            // 
            this.xtraTabPageUsers.Controls.Add(this.gridControlUsers);
            this.xtraTabPageUsers.Name = "xtraTabPageUsers";
            this.xtraTabPageUsers.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageUsers.Text = "Users";
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.DataSource = typeof(BookClub.Models.User);
            this.gridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsers.Location = new System.Drawing.Point(0, 0);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(897, 616);
            this.gridControlUsers.TabIndex = 0;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            this.gridControlUsers.Load += new System.EventHandler(this.gridControlUsers_Load);
            this.gridControlUsers.Enter += new System.EventHandler(this.gridControlUsers_Enter);
            this.gridControlUsers.Leave += new System.EventHandler(this.gridControlUsers_Leave);
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colRole,
            this.colEmail,
            this.colAboutMe});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewUsers_PopupMenuShowing);
            this.gridViewUsers.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridViewUsers_RowDeleted);
            this.gridViewUsers.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewUsers_RowUpdated);
            this.gridViewUsers.DoubleClick += new System.EventHandler(this.gridViewUsers_DoubleClick);
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colAboutMe
            // 
            this.colAboutMe.FieldName = "AboutMe";
            this.colAboutMe.Name = "colAboutMe";
            this.colAboutMe.Visible = true;
            this.colAboutMe.VisibleIndex = 4;
            // 
            // xtraTabPageSettings
            // 
            this.xtraTabPageSettings.Name = "xtraTabPageSettings";
            this.xtraTabPageSettings.Size = new System.Drawing.Size(897, 616);
            this.xtraTabPageSettings.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 641);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.navBarControlMain);
            this.Name = "MainForm";
            this.Text = "Bookclub";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetingRecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMeetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetingComs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMeetings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageHome.ResumeLayout(false);
            this.xtraScrollableControlMain.ResumeLayout(false);
            this.xtraScrollableControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNoMeetings)).EndInit();
            this.panelControlNoMeetings.ResumeLayout(false);
            this.panelControlNoMeetings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelNextMeeting)).EndInit();
            this.tablePanelNextMeeting.ResumeLayout(false);
            this.tablePanelNextMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.xtraTabPageMeetings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMeetingComments)).EndInit();
            this.xtraTabPageLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocations)).EndInit();
            this.xtraTabPageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.xtraTabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControlMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemHome;
        private DevExpress.XtraNavBar.NavBarItem navBarItemMeetings;
        private DevExpress.XtraNavBar.NavBarItem navBarItemLocations;
        private DevExpress.XtraNavBar.NavBarItem navBarItemBooks;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemUsers;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSettings;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHome;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMeetings;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLocations;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageBooks;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUsers;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSettings;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Label labelGreeting;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.GridControl gridControlBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBooks;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAboutMe;
        private DevExpress.XtraGrid.Columns.GridColumn colThumbnail;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colPages;
        private DevExpress.XtraGrid.Columns.GridColumn colPublished;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.GridControl gridControlLocations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLocations;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress2;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colZip;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.GridControl gridControlMeetings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMeetings;
        private DevExpress.XtraGrid.Columns.GridColumn colMeetTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBook;
        private DevExpress.XtraGrid.Columns.GridColumn colHost;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription2;
        private DevExpress.Utils.Layout.TablePanel tablePanelNextMeeting;
        private DevExpress.XtraEditors.LabelControl labelControlCityStateZip;
        private DevExpress.XtraEditors.LabelControl labelControlAddress2;
        private DevExpress.XtraEditors.LabelControl labelControlAddress1;
        private DevExpress.XtraEditors.LabelControl labelControlHostname;
        private DevExpress.XtraEditors.LabelControl labelControlBookAuthor;
        private DevExpress.XtraEditors.LabelControl labelControlMeetingTime;
        private DevExpress.XtraEditors.LabelControl labelControlHost;
        private DevExpress.XtraEditors.LabelControl labelControlLocation;
        private DevExpress.XtraEditors.LabelControl labelControlBookTitle;
        private DevExpress.XtraEditors.LabelControl labelControlBook;
        private DevExpress.XtraEditors.LabelControl labelControlNextMeeting;
        private DevExpress.XtraEditors.LabelControl labelControlNoMeetings;
        private DevExpress.XtraEditors.LabelControl labelControlAuthor;
        private DevExpress.XtraEditors.PanelControl panelControlNoMeetings;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddMeeting;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.PanelControl panelControlMeetingComments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMeetingRecs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMeetingComs;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBook;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCreated;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComUser;
    }
}


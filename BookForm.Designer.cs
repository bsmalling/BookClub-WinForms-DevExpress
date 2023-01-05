namespace BookClub
{
    partial class BookForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.textEditASIN = new DevExpress.XtraEditors.TextEdit();
            this.textEditISBN = new DevExpress.XtraEditors.TextEdit();
            this.textEditAuthor = new DevExpress.XtraEditors.TextEdit();
            this.textEditTitle = new DevExpress.XtraEditors.TextEdit();
            this.dateEditPublished = new DevExpress.XtraEditors.DateEdit();
            this.spinEditPages = new DevExpress.XtraEditors.SpinEdit();
            this.memoExEditDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditASIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPublished.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPublished.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(44, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Title:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Author:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Description:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Pages:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 246);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "ISBN:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 277);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "ASIN:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 307);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Published:";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(356, 307);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 8;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonOK.Appearance.Options.UseFont = true;
            this.simpleButtonOK.Location = new System.Drawing.Point(437, 307);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 7;
            this.simpleButtonOK.Text = "OK";
            // 
            // textEditASIN
            // 
            this.textEditASIN.Location = new System.Drawing.Point(78, 274);
            this.textEditASIN.Name = "textEditASIN";
            this.textEditASIN.Properties.MaxLength = 20;
            this.textEditASIN.Size = new System.Drawing.Size(147, 20);
            this.textEditASIN.TabIndex = 5;
            this.textEditASIN.Enter += new System.EventHandler(this.textEditASIN_Enter);
            this.textEditASIN.Leave += new System.EventHandler(this.textEditASIN_Leave);
            // 
            // textEditISBN
            // 
            this.textEditISBN.Location = new System.Drawing.Point(78, 243);
            this.textEditISBN.Name = "textEditISBN";
            this.textEditISBN.Properties.MaxLength = 24;
            this.textEditISBN.Size = new System.Drawing.Size(147, 20);
            this.textEditISBN.TabIndex = 4;
            this.textEditISBN.Enter += new System.EventHandler(this.textEditISBN_Enter);
            this.textEditISBN.Leave += new System.EventHandler(this.textEditISBN_Leave);
            // 
            // textEditAuthor
            // 
            this.textEditAuthor.Location = new System.Drawing.Point(78, 45);
            this.textEditAuthor.Name = "textEditAuthor";
            this.textEditAuthor.Properties.MaxLength = 100;
            this.textEditAuthor.Size = new System.Drawing.Size(434, 20);
            this.textEditAuthor.TabIndex = 1;
            this.textEditAuthor.Enter += new System.EventHandler(this.textEditAuthor_Enter);
            this.textEditAuthor.Leave += new System.EventHandler(this.textEditAuthor_Leave);
            // 
            // textEditTitle
            // 
            this.textEditTitle.Location = new System.Drawing.Point(78, 13);
            this.textEditTitle.Name = "textEditTitle";
            this.textEditTitle.Properties.MaxLength = 100;
            this.textEditTitle.Size = new System.Drawing.Size(434, 20);
            this.textEditTitle.TabIndex = 0;
            // 
            // dateEditPublished
            // 
            this.dateEditPublished.EditValue = null;
            this.dateEditPublished.Location = new System.Drawing.Point(78, 304);
            this.dateEditPublished.Name = "dateEditPublished";
            this.dateEditPublished.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPublished.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPublished.Size = new System.Drawing.Size(147, 20);
            this.dateEditPublished.TabIndex = 6;
            // 
            // spinEditPages
            // 
            this.spinEditPages.EditValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spinEditPages.Location = new System.Drawing.Point(78, 207);
            this.spinEditPages.Name = "spinEditPages";
            this.spinEditPages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPages.Size = new System.Drawing.Size(64, 20);
            this.spinEditPages.TabIndex = 3;
            // 
            // memoExEditDescription
            // 
            this.memoExEditDescription.Location = new System.Drawing.Point(78, 81);
            this.memoExEditDescription.Name = "memoExEditDescription";
            this.memoExEditDescription.Properties.MaxLength = 500;
            this.memoExEditDescription.Size = new System.Drawing.Size(434, 113);
            this.memoExEditDescription.TabIndex = 2;
            // 
            // BookForm
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(538, 342);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.textEditASIN);
            this.Controls.Add(this.textEditISBN);
            this.Controls.Add(this.textEditAuthor);
            this.Controls.Add(this.textEditTitle);
            this.Controls.Add(this.dateEditPublished);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.spinEditPages);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoExEditDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditASIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPublished.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPublished.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEditDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditPages;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit memoExEditDescription;
        private DevExpress.XtraEditors.DateEdit dateEditPublished;
        private DevExpress.XtraEditors.TextEdit textEditTitle;
        private DevExpress.XtraEditors.TextEdit textEditAuthor;
        private DevExpress.XtraEditors.TextEdit textEditISBN;
        private DevExpress.XtraEditors.TextEdit textEditASIN;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
    }
}
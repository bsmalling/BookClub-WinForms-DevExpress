namespace BookClub
{
    partial class RecommendationForm
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
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAddNewBook = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditComment = new DevExpress.XtraEditors.MemoEdit();
            this.comboBoxEditBook = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBook.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Book:";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(463, 162);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 4;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButtonOK.Appearance.Options.UseFont = true;
            this.simpleButtonOK.Location = new System.Drawing.Point(544, 162);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 3;
            this.simpleButtonOK.Text = "OK";
            // 
            // simpleButtonAddNewBook
            // 
            this.simpleButtonAddNewBook.Location = new System.Drawing.Point(499, 7);
            this.simpleButtonAddNewBook.Name = "simpleButtonAddNewBook";
            this.simpleButtonAddNewBook.Size = new System.Drawing.Size(120, 23);
            this.simpleButtonAddNewBook.TabIndex = 1;
            this.simpleButtonAddNewBook.Text = "Add a new Book...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Comment:";
            // 
            // memoEditComment
            // 
            this.memoEditComment.Location = new System.Drawing.Point(67, 45);
            this.memoEditComment.Name = "memoEditComment";
            this.memoEditComment.Properties.MaxLength = 500;
            this.memoEditComment.Size = new System.Drawing.Size(410, 96);
            this.memoEditComment.TabIndex = 2;
            this.memoEditComment.Enter += new System.EventHandler(this.memoEditComment_Enter);
            this.memoEditComment.Leave += new System.EventHandler(this.memoEditComment_Leave);
            // 
            // comboBoxEditBook
            // 
            this.comboBoxEditBook.Location = new System.Drawing.Point(67, 9);
            this.comboBoxEditBook.Name = "comboBoxEditBook";
            this.comboBoxEditBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBook.Size = new System.Drawing.Size(411, 20);
            this.comboBoxEditBook.TabIndex = 0;
            // 
            // RecommendationForm
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(635, 201);
            this.Controls.Add(this.memoEditComment);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButtonAddNewBook);
            this.Controls.Add(this.comboBoxEditBook);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecommendationForm";
            this.ShowInTaskbar = false;
            this.Text = "RecommendationForm";
            this.Load += new System.EventHandler(this.RecommendationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBook.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBook;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddNewBook;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEditComment;
    }
}
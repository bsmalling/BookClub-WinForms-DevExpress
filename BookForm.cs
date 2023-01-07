using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookClub.Models;

namespace BookClub
{

    public partial class BookForm : Form
    {

        public Book CurrentBook { get; set; }

        private Color m_foreColor;
        private const string c_authorHint = "Last name, First name";
        private const string c_isbnHint = "NNN-NNNNNNNNNN";
        private const string c_asinHint = "BXXXXXXXXX";

        public BookForm()
        {
            InitializeComponent();
            m_foreColor = textEditAuthor.ForeColor;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (CurrentBook == null)
            {
                CurrentBook = new Book(-1);
            }
            else
            {
                textEditTitle.Text = CurrentBook.Title;
                textEditAuthor.Text = CurrentBook.Author;
                memoExEditDescription.Text = CurrentBook.Description;
                spinEditPages.Value = CurrentBook.Pages ?? 0;
                textEditISBN.Text = CurrentBook.ISBN;
                textEditASIN.Text = CurrentBook.ASIN;
                dateEditPublished.DateTime = CurrentBook.Published;
            }
            
            ShowTextEditHint(textEditAuthor, c_authorHint);
            ShowTextEditHint(textEditISBN, c_isbnHint);
            ShowTextEditHint(textEditASIN, c_asinHint);
        }

        private void ShowTextEditHint(TextEdit editor, string hint)
        {
            if (String.IsNullOrEmpty(editor.Text))
            {
                editor.ForeColor = Color.DimGray;
                editor.Text = hint;
            }
        }

        private void HideTextEditHint(TextEdit editor, string hint)
        {
            if (editor.Text == hint)
            {
                editor.ForeColor = m_foreColor;
                editor.Text = String.Empty;
            }
        }

        private void textEditAuthor_Enter(object sender, EventArgs e)
        {
            HideTextEditHint(textEditAuthor, c_authorHint);
        }

        private void textEditAuthor_Leave(object sender, EventArgs e)
        {
            ShowTextEditHint(textEditAuthor, c_authorHint);
        }

        private void textEditISBN_Enter(object sender, EventArgs e)
        {
            HideTextEditHint(textEditISBN, c_isbnHint);
        }

        private void textEditISBN_Leave(object sender, EventArgs e)
        {
            ShowTextEditHint(textEditISBN, c_isbnHint);
        }

        private void textEditASIN_Enter(object sender, EventArgs e)
        {
            HideTextEditHint(textEditASIN, c_asinHint);
        }

        private void textEditASIN_Leave(object sender, EventArgs e)
        {
            ShowTextEditHint(textEditASIN, c_asinHint);
        }

    }

}

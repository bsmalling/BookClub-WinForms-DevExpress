using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookClub
{

    public partial class RecommendationForm : Form
    {

        private Color m_foreColor;
        private const string c_commentHint = "(Optional)";

        public RecommendationForm()
        {
            InitializeComponent();
        }

        private void RecommendationForm_Load(object sender, EventArgs e)
        {
            m_foreColor = memoEditComment.ForeColor;
            memoEditComment_Leave(sender, e);
        }

        private void memoEditComment_Enter(object sender, EventArgs e)
        {
            if (memoEditComment.Text == c_commentHint)
            {
                memoEditComment.Text = String.Empty;
                memoEditComment.ForeColor = m_foreColor;
            }
        }

        private void memoEditComment_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(memoEditComment.Text))
            {
                memoEditComment.Text = c_commentHint;
                memoEditComment.ForeColor = Color.DimGray;
            }
        }

        private void simpleButtonAddNewBook_Click(object sender, EventArgs e)
        {
            using (BookForm form = new BookForm())
            {
                form.Text = "Add a new Book";
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: To be completed...
                }
            }
        }

    }

}

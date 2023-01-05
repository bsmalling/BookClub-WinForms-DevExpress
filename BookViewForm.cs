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

    public partial class BookViewForm : Form
    {

        public Book CurrentBook { get; set; }

        public BookViewForm()
        {
            InitializeComponent();
        }

        private void BookViewForm_Load(object sender, EventArgs e)
        {
            UpdateBook();
        }

        private void UpdateBook()
        {
            Text = CurrentBook.Title + " by " + CurrentBook.Author;
            labelControlTitle.Text = Util.Ellipses(50, CurrentBook.Title);
            labelControlAuthor.Text = Util.Ellipses(80, "by " + CurrentBook.Author);
            labelControlPagesValue.Text = (CurrentBook.Pages != null) ?
                string.Format("{0:N0}", CurrentBook.Pages) : "-";
            labelControlISBNValue.Text = CurrentBook.ISBN ?? "-";
            labelControlASINValue.Text = CurrentBook.ASIN ?? "-";
            labelControlPublishedValue.Text = CurrentBook.Published.ToString("MMMM d, yyyy");

            if (CurrentBook.Thumbnail?.ImageObj != null)
                pictureEditCover.Image = CurrentBook.Thumbnail.ImageObj;

            gridControlComments.DataSource = CurrentBook.Comments;
        }

    }

}

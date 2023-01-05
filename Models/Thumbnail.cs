using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace BookClub.Models
{

    public class Thumbnail
    {

        [Key]
        public int Id { get; private set; }

        [Required]
        public Image ImageObj { get; set; }

        public ChangeStatus Status { get; set; }

        // Methods

        public Thumbnail(int id)
        {
            Id = id;
        }

        public Thumbnail(
            int id,
            Image imageObj)
        {
            Id = id;
            ImageObj = imageObj;
        }

        ///<summary>
        ///This method should only be called by the ThumbnailService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

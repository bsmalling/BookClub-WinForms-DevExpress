using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Models
{

    public class Comment
    {

        [Key]
        public int Id { get; private set; }

        [Required]
        public ParentType ParentType { get; set; }

        [Required]
        public int ParentId { get; set; }

        [Required]
        [MaxLength(500), MinLength(1)]
        public string Text { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public ChangeStatus Status { get; set; }

        // Referenced objects

        public virtual User User { get; set; }

        // Methods

        public Comment(int id)
        {
            Id = id;
        }

        public Comment(
            int id,
            ParentType parentType,
            int parentId,
            string text,
            int userId,
            DateTime? created = null)
        {
            Id = id;
            ParentType = parentType;
            ParentId = parentId;
            Text = text;
            UserId = userId;
            Created = (created == null) ? DateTime.Now : (DateTime)created;
        }

        ///<summary>
        ///This method should only be called by the CommentService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

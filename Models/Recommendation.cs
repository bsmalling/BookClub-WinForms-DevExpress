using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub.Models
{

    public class Recommendation : Commentable
    {

        [Key]
        public int Id { get; private set; }

        [Required]
        public int MeetingId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public ChangeStatus Status { get; set; }

        // Referenced objects

        public virtual Meeting Meeting { get; set; }

        public virtual Book Book { get; set; }

        public virtual User User { get; set; }

        public virtual List<Comment> Comments
        {
            get
            {
                return LoadComments(ParentType.Recommendation, Id);
            }
            set
            {
                SaveComments(ParentType.Recommendation, Id);
            }
        }

        // Methods


        public Recommendation(int id)
        {
            Id = id;
        }

        public Recommendation(
            int id,
            int meetingId,
            int bookId,
            int userId,
            DateTime? created = null)
        {
            Id = id;
            MeetingId = meetingId;
            BookId = bookId;
            UserId = userId;
            Created = (created == null) ? DateTime.Now : (DateTime)created;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Recommendation;
            if (item == null) return false;

            return Id.Equals(item.Id);
        }

        public override int GetHashCode()
        {
            return (Id.ToString() + MeetingId.ToString()).GetHashCode();
        }

        ///<summary>
        ///This method should only be called by the RecommendationService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

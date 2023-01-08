using BookClub.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace BookClub.Models
{

    public class Meeting : Commentable
    {

        private Book m_book;
        private User m_host;
        private Location m_location;

        private List<Recommendation> m_recommendations = new List<Recommendation>();

        [Key]
        public int Id { get; private set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int HostId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        public DateTime MeetTime { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public ChangeStatus Status { get; set; }

        // Referenced objects

        public virtual Book Book {
            get {
                return m_book;
            }
            set {
                m_book = value;
                BookId = value.Id;
            }
        }

        public virtual User Host {
            get {
                return m_host;
            }
            set {
                m_host = value;
                HostId = value.Id;
            }
        }

        public virtual Location Location {
            get
            {
                return m_location;
            }
            set
            {
                m_location = value;
                LocationId = value.Id;
            }
        }

        public virtual List<Recommendation> Recommendations
        {
            get
            {
                return LoadRecommendations();
            }
            set
            {
                SaveRecommendations();
            }
        }

        public virtual List<Comment> Comments
        {
            get
            {
                return LoadComments(ParentType.Meeting, Id);
            }
            set
            {
                SaveComments(ParentType.Meeting, Id);
            }
        }

        // Methods

        public Meeting(int id)
        {
            Id = id;
        }

        public Meeting(
            int id,
            int bookId,
            int hostId,
            int locationId,
            DateTime meetTime,
            string description = null)
        {
            Id = id;
            BookId = bookId;
            HostId = hostId;
            LocationId = locationId;
            MeetTime = meetTime;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Meeting;
            if (item == null) return false;

            return Id.Equals(item.Id);
        }

        public override int GetHashCode()
        {
            return (Id.ToString() + BookId.ToString()).GetHashCode();
        }

        private List<Recommendation> LoadRecommendations()
        {
            if (m_recommendations.Count == 0)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    using (var recommendationService = new RecommendationService(connection))
                        m_recommendations = recommendationService.ReadByMeeting(Id);
                }
            }
            return m_recommendations;
        }

        private void SaveRecommendations()
        {
            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();
                using (var recommendationService = new RecommendationService(connection))
                    if (m_recommendations == null || m_recommendations.Count == 0)
                        recommendationService.DeleteByMeeting(Id);
                    else
                        recommendationService.UpdateAll(Id, m_recommendations);
            }
        }

        public void AddRecommendation(Recommendation recommendation)
        {
            recommendation.Status = ChangeStatus.New;
            m_recommendations.Add(recommendation);
        }

        public void DeleteRecommendation(Recommendation recommendation)
        {
            recommendation.Status = ChangeStatus.Deleted;
        }

        ///<summary>
        ///This method should only be called by the MeetingService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

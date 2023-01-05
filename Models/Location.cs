using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace BookClub.Models
{

    public class Location
    {

        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(100), MinLength(3)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [Required]
        [MaxLength(100), MinLength(3)]
        public string City { get; set; }

        [Required]
        [MaxLength(50), MinLength(2)]
        public string State { get; set; }

        [MaxLength(10), MinLength(5)]
        public string Zip { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public ChangeStatus Status { get; set; }

        // Methods

        public Location(int id)
        {
            Id = id;
        }

        public Location(
            int id,
            string address1,
            string address2,
            string city,
            string state,
            string zip = null,
            string description = null)
        {
            Id = id;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Location;
            if (item == null) return false;

            return Id.Equals(item.Id);
        }

        public override int GetHashCode()
        {
            return (Id.ToString() + Address1).GetHashCode();
        }

        public override string ToString()
        {
            return Address1;
        }

        ///<summary>
        ///This method should only be called by the LocationService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

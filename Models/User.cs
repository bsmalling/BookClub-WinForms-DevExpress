using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace BookClub.Models
{

    public class User
    {

        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(100), MinLength(3)]
        public string Username { get; private set; }

        [Required]
        [MaxLength(40), MinLength(40)]
        public string PwdHash { get; set; }

        [Required]
        [MaxLength(100), MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100), MinLength(1)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100), MinLength(5)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string AboutMe { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public ChangeStatus Status { get; set; }

        // Methods

        public User(int id, string username)
        {
            Id = id;
            Username = username;
        }

        public User(
            int id,
            string username,
            string pwdHash,
            string firstName,
            string lastName,
            string email,
            string aboutMe,
            UserRole role)
        {
            Id = id;
            Username = username;
            PwdHash = pwdHash;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            AboutMe = aboutMe;
            Role = role;
        }

        public bool IsCorrectPassword(string username, string password)
        {
            return PwdHash == HashPassword(username, password);
        }

        public static string HashPassword(string username, string password)
        {
            using (var sha1 = new SHA1Managed())
            {
                // Include username to prevent identical passwords from having the same hash.
                var combo = username + "|" + password;
                var bytes = sha1.ComputeHash(Encoding.Unicode.GetBytes(combo));
                return string.Join("", bytes.Select(x => x.ToString("x2")));
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public override bool Equals(object obj)
        {
            var item = obj as User;
            if (item == null) return false;

            return Id.Equals(item.Id);
        }

        public override int GetHashCode()
        {
            return (Id.ToString() + FullName).GetHashCode();
        }

        public override string ToString()
        {
            return FullName;
        }

        public bool HasRole(UserRole role)
        {
            return (Role & role) == role;
        }

        ///<summary>
        ///This method should only be called by the UserService class!
        ///</summary>
        public void ServiceSetId__(int id)
        {
            Id = id;
        }

    }

}

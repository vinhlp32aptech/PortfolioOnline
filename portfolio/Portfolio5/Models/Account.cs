using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Account
    {
        public Account()
        {
            Feedbacks = new HashSet<Feedback>();
            Follows = new HashSet<Follow>();
            HashtagUsers = new HashSet<HashtagUser>();
            Ratings = new HashSet<Rating>();
            SocialUsers = new HashSet<SocialUser>();
            UserRoles = new HashSet<UserRole>();
            Views = new HashSet<View>();
        }

        public string IdAcc { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
        public bool? Stat { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<HashtagUser> HashtagUsers { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<SocialUser> SocialUsers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<View> Views { get; set; }
    }
}

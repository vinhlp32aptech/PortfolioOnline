using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Models
{
    public class AllUserAcc
    {
        // bảng gộp giữa user và account
        public User User { get; set; }
        public Account Account { get; set; }
        public Follow Follow { get; set; }
        public SocialUser  SocialUser { get; set; }

        public Rating Rating { get; set; }

        public Role Role { get; set; }
    }
}

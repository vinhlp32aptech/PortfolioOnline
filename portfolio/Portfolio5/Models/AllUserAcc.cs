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
}
}

using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.EF
{
    class PortfolioDBContext : DbContext
    {
        public PortfolioDBContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SocialUser> SocialUsers { get; set; }
        public DbSet<View> views { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Rating> Ratings { get; set; }

    }
}

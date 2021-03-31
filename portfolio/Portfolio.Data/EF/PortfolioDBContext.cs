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
        public DbSet<View> Views { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<HashtagUser> HashtagUsers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<FooterContact> FooterContacts { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SocialWed> SocialWeds { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderUrl> SliderUrls { get; set; }
        public DbSet<SliderPhoto> SliderPhotos { get; set; }
        public DbSet<ContentPage> ContentPages { get; set; }
        public DbSet<SessionPage> SessionPages { get; set; }
        public DbSet<SubtitleSessionPage> SubtitleSessionPages { get; set; }
        public DbSet<PhotoSessionPage> PhotoSessionPages { get; set; }
        public DbSet<IconSessionPage> IconSessionPages { get; set; }
        public DbSet<UrlSessionPage> UrlSessionPages { get; set; }
    }
}

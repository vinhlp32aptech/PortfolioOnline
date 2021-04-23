using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Portfolio5.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ContentPage> ContentPages { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Follow> Follows { get; set; }
        public virtual DbSet<FooterContact> FooterContacts { get; set; }
        public virtual DbSet<Hashtag> Hashtags { get; set; }
        public virtual DbSet<HashtagUser> HashtagUsers { get; set; }
        public virtual DbSet<IconSessionPage> IconSessionPages { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<PhotoSessionPage> PhotoSessionPages { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SendMail> SendMails { get; set; }
        public virtual DbSet<SessionPage> SessionPages { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SliderPart> SliderParts { get; set; }
        public virtual DbSet<SocialUser> SocialUsers { get; set; }
        public virtual DbSet<SocialWeb> SocialWebs { get; set; }
        public virtual DbSet<SubtitleSessionPage> SubtitleSessionPages { get; set; }
        public virtual DbSet<UrlSessionPage> UrlSessionPages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<View> Views { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAcc)
                    .HasName("PK__account__6BE8F064B64F1E4E");

                entity.ToTable("account");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdRole)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_role");

                entity.Property(e => e.Pass)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Stat).HasColumnName("stat");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_account_role");
            });

            modelBuilder.Entity<ContentPage>(entity =>
            {
                entity.HasKey(e => e.IdContentPage)
                    .HasName("PK__content___249939A6D51F1CEA");

                entity.ToTable("content_page");

                entity.Property(e => e.IdContentPage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_content_page");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.NamePage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_page");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.IdFeedback)
                    .HasName("PK__feedback__36BC8630D6D95404");

                entity.ToTable("feedback");

                entity.Property(e => e.IdFeedback)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_feedback");

                entity.Property(e => e.Datereply)
                    .HasColumnType("datetime")
                    .HasColumnName("datereply");

                entity.Property(e => e.Datesend)
                    .HasColumnType("datetime")
                    .HasColumnName("datesend");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.Mess)
                    .HasMaxLength(1000)
                    .HasColumnName("mess");

                entity.Property(e => e.ReplyMail)
                    .HasMaxLength(1000)
                    .HasColumnName("reply_mail");

                entity.Property(e => e.Stat).HasColumnName("stat");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.IdAcc)
                    .HasConstraintName("FK_feedback_account");
            });

            modelBuilder.Entity<Follow>(entity =>
            {
                entity.HasKey(e => e.IdFollow)
                    .HasName("PK__follow__C9ED4B392D6AC079");

                entity.ToTable("follow");

                entity.Property(e => e.IdFollow)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_follow");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.IdFollower)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_follower");

                entity.Property(e => e.NumOfFollow)
                    .HasColumnName("num_of_follow")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.Follows)
                    .HasForeignKey(d => d.IdAcc)
                    .HasConstraintName("FK_follow_account");
            });

            modelBuilder.Entity<FooterContact>(entity =>
            {
                entity.HasKey(e => e.IdWebContact)
                    .HasName("PK__footer_c__1CC567BA13F4E455");

                entity.ToTable("footer_contact");

                entity.Property(e => e.IdWebContact)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_web_contact");

                entity.Property(e => e.ContentContact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("content_contact");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IconContact)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("icon_contact");

                entity.Property(e => e.NameContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_contact");
            });

            modelBuilder.Entity<Hashtag>(entity =>
            {
                entity.HasKey(e => e.IdHashtag)
                    .HasName("PK__hashtag__660123E16BF995C8");

                entity.ToTable("hashtag");

                entity.Property(e => e.IdHashtag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_hashtag");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.NameHashtag)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_hashtag");

                entity.Property(e => e.Stat).HasColumnName("stat");
            });

            modelBuilder.Entity<HashtagUser>(entity =>
            {
                entity.HasKey(e => new { e.IdHashtag, e.IdAcc })
                    .HasName("PK__hashtag___30BFACE7F9B220F0");

                entity.ToTable("hashtag_user");

                entity.Property(e => e.IdHashtag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_hashtag");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.NameHashtag)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_hashtag");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.HashtagUsers)
                    .HasForeignKey(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hashtag_user_account");

                entity.HasOne(d => d.IdHashtagNavigation)
                    .WithMany(p => p.HashtagUsers)
                    .HasForeignKey(d => d.IdHashtag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hashtag_user_hashtag");
            });

            modelBuilder.Entity<IconSessionPage>(entity =>
            {
                entity.HasKey(e => e.IdIconSess)
                    .HasName("PK__icon_ses__C1A68C0BAF52E3F8");

                entity.ToTable("icon_session_page");

                entity.Property(e => e.IdIconSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_icon_sess");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IconSess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("icon_sess");

                entity.Property(e => e.IdSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sess");

                entity.HasOne(d => d.IdSessNavigation)
                    .WithMany(p => p.IconSessionPages)
                    .HasForeignKey(d => d.IdSess)
                    .HasConstraintName("FK_icon_session_page_session_page");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK__menu__68A1D9DB1B5374CB");

                entity.ToTable("menu");

                entity.Property(e => e.IdMenu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_menu");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.NameMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_menu");

                entity.Property(e => e.UrlMenu)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("url_menu");
            });

            modelBuilder.Entity<PhotoSessionPage>(entity =>
            {
                entity.HasKey(e => e.IdPhotoSess)
                    .HasName("PK__photo_se__343ED92413C7D038");

                entity.ToTable("photo_session_page");

                entity.Property(e => e.IdPhotoSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_photo_sess");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sess");

                entity.Property(e => e.PhotoSess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("photo_sess");

                entity.HasOne(d => d.IdSessNavigation)
                    .WithMany(p => p.PhotoSessionPages)
                    .HasForeignKey(d => d.IdSess)
                    .HasConstraintName("FK_photo_session_page_session_page");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => e.IdRating)
                    .HasName("PK__rating__12074E47B302DE00");

                entity.ToTable("rating");

                entity.Property(e => e.IdRating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_rating");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.IdReviewer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_reviewer");

                entity.Property(e => e.NumOfRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("num_of_rating")
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength(true);

                entity.Property(e => e.StarOfRating).HasColumnName("star_of_rating");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.IdAcc)
                    .HasConstraintName("FK_rating_account");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__role__3D48441D0A2FB825");

                entity.ToTable("role");

                entity.Property(e => e.IdRole)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_role");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.Desc)
                    .HasMaxLength(1000)
                    .HasColumnName("desc");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(100)
                    .HasColumnName("name_role");
            });

            modelBuilder.Entity<SendMail>(entity =>
            {
                entity.HasKey(e => e.IdSendmail)
                    .HasName("PK__send_mai__0C5A08C1CF8AB584");

                entity.ToTable("send_mail");

                entity.Property(e => e.IdSendmail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sendmail");

                entity.Property(e => e.Datesend)
                    .HasColumnType("datetime")
                    .HasColumnName("datesend");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.Mess)
                    .HasMaxLength(1000)
                    .HasColumnName("mess");

                entity.Property(e => e.Stat).HasColumnName("stat");
            });

            modelBuilder.Entity<SessionPage>(entity =>
            {
                entity.HasKey(e => e.IdSess)
                    .HasName("PK__session___D692B7828112DD67");

                entity.ToTable("session_page");

                entity.Property(e => e.IdSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sess");

                entity.Property(e => e.ContentSess)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("content_sess");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdContentPage)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_content_page");

                entity.Property(e => e.NameSess)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_sess");

                entity.Property(e => e.TitleSess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("title_sess");

                entity.HasOne(d => d.IdContentPageNavigation)
                    .WithMany(p => p.SessionPages)
                    .HasForeignKey(d => d.IdContentPage)
                    .HasConstraintName("FK_session_page_content_page");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.HasKey(e => e.IdSlider)
                    .HasName("PK__slider__CADCE756DC51DA85");

                entity.ToTable("slider");

                entity.Property(e => e.IdSlider)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_slider");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");
            });

            modelBuilder.Entity<SliderPart>(entity =>
            {
                entity.HasKey(e => e.IdSliderPart)
                    .HasName("PK__slider_p__DA162D1E2E5F3A0C");

                entity.ToTable("slider_part");

                entity.Property(e => e.IdSliderPart)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_slider_part");

                entity.Property(e => e.ContentPart)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("content_part");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdSlider)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_slider");

                entity.Property(e => e.NameUrl)
                    .HasMaxLength(100)
                    .HasColumnName("name_url");

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.TitlePart)
                    .HasMaxLength(100)
                    .HasColumnName("title_part");

                entity.Property(e => e.UrlSlider)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url_slider");

                entity.HasOne(d => d.IdSliderNavigation)
                    .WithMany(p => p.SliderParts)
                    .HasForeignKey(d => d.IdSlider)
                    .HasConstraintName("FK_slider_part_slider");
            });

            modelBuilder.Entity<SocialUser>(entity =>
            {
                entity.HasKey(e => e.IdSocialUser)
                    .HasName("PK__social_u__82A2A77423164118");

                entity.ToTable("social_user");

                entity.Property(e => e.IdSocialUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_social_user");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IconSoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("icon_soc");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.NameSoc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_soc");

                entity.Property(e => e.UrlSoc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url_soc");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.SocialUsers)
                    .HasForeignKey(d => d.IdAcc)
                    .HasConstraintName("FK_social_user_account");
            });

            modelBuilder.Entity<SocialWeb>(entity =>
            {
                entity.HasKey(e => e.IdSoccialWeb)
                    .HasName("PK__social_w__68B762A835276B07");

                entity.ToTable("social_web");

                entity.Property(e => e.IdSoccialWeb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_soccial_web");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IconSoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("icon_soc");

                entity.Property(e => e.NameSoc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_soc");

                entity.Property(e => e.UrlSoc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url_soc");
            });

            modelBuilder.Entity<SubtitleSessionPage>(entity =>
            {
                entity.HasKey(e => e.IdSubtitleSess)
                    .HasName("PK__subtitle__EC9C00C6B0B40C7A");

                entity.ToTable("subtitle_session_page");

                entity.Property(e => e.IdSubtitleSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_subtitle_sess");

                entity.Property(e => e.ContentSubtitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("content_subtitle");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sess");

                entity.Property(e => e.SubtitleSess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("subtitle_sess");

                entity.HasOne(d => d.IdSessNavigation)
                    .WithMany(p => p.SubtitleSessionPages)
                    .HasForeignKey(d => d.IdSess)
                    .HasConstraintName("FK_subtitle_session_page_session_page");
            });

            modelBuilder.Entity<UrlSessionPage>(entity =>
            {
                entity.HasKey(e => e.IdUrlSess)
                    .HasName("PK__url_sess__5D2DFA4BA3E7DB0E");

                entity.ToTable("url_session_page");

                entity.Property(e => e.IdUrlSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_url_sess");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdSess)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_sess");

                entity.Property(e => e.UrlSess)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("url_sess");

                entity.HasOne(d => d.IdSessNavigation)
                    .WithMany(p => p.UrlSessionPages)
                    .HasForeignKey(d => d.IdSess)
                    .HasConstraintName("FK_url_session_page_session_page");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__user__D2D146371811B245");

                entity.ToTable("user");

                entity.HasIndex(e => e.IdAcc, "account_user")
                    .IsUnique();

                entity.Property(e => e.IdUser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_user");

                entity.Property(e => e.Addr)
                    .HasMaxLength(200)
                    .HasColumnName("addr");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .HasColumnName("job");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Project).HasColumnName("project");

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("website");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__user__id_acc__398D8EEE");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.HasKey(e => e.IdView)
                    .HasName("PK__view__5CB912AD3AAB662A");

                entity.ToTable("view");

                entity.Property(e => e.IdView)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_view");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Dateupdated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateupdated");

                entity.Property(e => e.IdAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_acc");

                entity.Property(e => e.IdViewer)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id_viewer");

                entity.Property(e => e.NumOfView)
                    .HasColumnName("num_of_view")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.Views)
                    .HasForeignKey(d => d.IdAcc)
                    .HasConstraintName("FK_view_account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

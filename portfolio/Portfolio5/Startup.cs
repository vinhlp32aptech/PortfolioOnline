using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio5.Areas.Admin.Services;
using Portfolio5.Models;
using Portfolio5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAuthentication
            (CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddControllersWithViews();
            services.AddSession();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies().UseSqlServer(connectionString));

            services.AddScoped<AccountService, AccountServiceImpl>();
            services.AddScoped<RatingService, RatingServiceImpl>();
            services.AddScoped<HashtagService, HashtagServiceImpl>();
            services.AddScoped<ViewService, ViewServiceImpl>();
            services.AddScoped<FollowService, FollowServiceImpl>();
            services.AddScoped<RoleService, RoleServiceImpl>();
            services.AddScoped<SliderService, SliderServiceImpl>();
            services.AddScoped<SliderPartService, SliderPartServiceImpl>();
            services.AddScoped<ContentPageService, ContentPageServiceImpl>();
            services.AddScoped<SessionPageService, SessionPageServiceImpl>();
            services.AddScoped<IconSessionPageService, IconSessionPageServiceImpl>();
            services.AddScoped<PhotoSessionPageService, PhotoSessionPageServiceImpl>();
            services.AddScoped<SubtitleSessionPageService, SubtitleSessionPageServiceImpl>();
            services.AddScoped<UrlSessionPageService, UrlSessionPageServiceImpl>();
            services.AddScoped<SocialUserService, SocialUserServiceImpl>();
            services.AddScoped<SigninService, SigninServiceImpl>();
            services.AddScoped<SignupService, SignupServiceImpl>();
            services.AddScoped<ProfieService, ProfieServiceImpl>();
            services.AddScoped<IndexService, IndexServiceImpl>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            // who are you?  
            app.UseAuthentication();

            // are you allowed?  
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Index}/{action=Index}/{id?}");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SneakersApp.Data;
using Microsoft.EntityFrameworkCore;
using SneakersApp.Services;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SneakersApp.Data.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using Microsoft.IdentityModel.Tokens;
using SneakersApp.Models;
using System.Text;

namespace SneakersApp
{
    public class Startup
    {

        private string _connection = null;

        public Startup(IHostingEnvironment env)
        {

            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json",
                         optional: false,
                         reloadOnChange: true)
            .AddEnvironmentVariables();

                if (env.IsDevelopment())
                {
                    builder.AddUserSecrets<Startup>();
                }

                Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new SqlConnectionStringBuilder(
            Configuration.GetConnectionString("DefaultConnection"));
            builder.Password = Configuration["DbPassword"];
            builder.UserID = Configuration["DbUser"];
            builder.DataSource = Configuration["DbServer"];
            _connection = builder.ConnectionString;

            services.AddDbContext<SneakersAppDbContext>(options =>
                options.UseSqlServer(_connection, b => b.MigrationsAssembly("SneakersApp"))
            );

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SneakersAppDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;

                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);

                options.LoginPath = "/Account/login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<ICollection, CollectionsService>();
            services.AddScoped<IShoe, ShoesService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAuthentication()
                .AddCookie(cfg => cfg.SlidingExpiration = true)
                .AddJwtBearer(cfg =>
                {
                    cfg.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidIssuer = SneakersJWTTokens.Issuer,
                        ValidAudience = SneakersJWTTokens.Audience,
                        IssuerSigningKey =
                            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SneakersJWTTokens.Key))
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
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
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(ConfigureRoute);
        }

        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {

            //routeBuilder.MapRoute(
              //  name: "areas",
               // template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

            routeBuilder.MapRoute(
                name: "Default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Home", action = "Index" });
        }
    }
}

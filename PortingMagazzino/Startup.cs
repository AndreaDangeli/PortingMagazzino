using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PortingMagazzino.Data.Models;
using PortingMagazzino.Servizi.Implementations;
using PortingMagazzino.Servizi.Interfaces;
using PortingMagazzino.TesisData.TesisModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PortingMagazzino
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Get Identity Default Options
            //IConfigurationSection identityDefaultOptionsConfigurationSection = Configuration.GetSection("IdentityDefaultOptions");

            //services.Configure<IdentityDefaultOptions>(identityDefaultOptionsConfigurationSection);

            //var identityDefaultOptions = identityDefaultOptionsConfigurationSection.Get<IdentityDefaultOptions>();

            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    // Password settings
            //    //options.Password.RequireDigit = identityDefaultOptions.PasswordRequireDigit;
            //    //options.Password.RequiredLength = identityDefaultOptions.PasswordRequiredLength;
            //    //options.Password.RequireNonAlphanumeric = identityDefaultOptions.PasswordRequireNonAlphanumeric;
            //    //options.Password.RequireUppercase = identityDefaultOptions.PasswordRequireUppercase;
            //    //options.Password.RequireLowercase = identityDefaultOptions.PasswordRequireLowercase;
            //    //options.Password.RequiredUniqueChars = identityDefaultOptions.PasswordRequiredUniqueChars;
            //    options.Password.RequireDigit = false;
            //    options.Password.RequiredLength = 1;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //    options.Password.RequireLowercase = false;

            //    // Lockout settings
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(identityDefaultOptions.LockoutDefaultLockoutTimeSpanInMinutes);
            //    options.Lockout.MaxFailedAccessAttempts = identityDefaultOptions.LockoutMaxFailedAccessAttempts;
            //    options.Lockout.AllowedForNewUsers = identityDefaultOptions.LockoutAllowedForNewUsers;

            //    // User settings
            //    //options.User.RequireUniqueEmail = identityDefaultOptions.UserRequireUniqueEmail;

            //    // email confirmation require
            //    //options.SignIn.RequireConfirmedEmail = identityDefaultOptions.SignInRequireConfirmedEmail;
            //})
            //    .AddEntityFrameworkStores<MagazzinoContext>()
            //    .AddDefaultTokenProviders();

            // cookie settings
            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = identityDefaultOptions.CookieHttpOnly;
            //    options.ExpireTimeSpan = TimeSpan.FromDays(identityDefaultOptions.CookieExpiration);
            //    options.LoginPath = identityDefaultOptions.LoginPath; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
            //    options.LogoutPath = identityDefaultOptions.LogoutPath; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
            //    options.AccessDeniedPath = identityDefaultOptions.AccessDeniedPath; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
            //    options.SlidingExpiration = identityDefaultOptions.SlidingExpiration;
            //});

            services.AddControllersWithViews();

            services.AddDbContext<TesisContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Magazzino_ConnectionString")));

            //services.AddDbContext<DbContextRetGruppiFunzioni>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("Magazzino_ConnectionString")));

            services.AddDbContext<MagazzinoContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Magazzino_ConnectionString"),
                    sqlServerOptions =>
                    {
                        sqlServerOptions.MigrationsHistoryTable("__EFMigrationsHistory", "Magazzino");
                    });
            });

            services.AddScoped<IShipmentViewModelService, ShipmentViewModelService>();
            services.AddScoped<IFaFaIconeManager, FaFaIconeManager>();
            services.AddScoped<ITranslate, Translate>();
            // Localizzazione
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            // Get Super Admin Default options
            //services.Configure<SuperAdminDefaultOptions>(Configuration.GetSection("SuperAdminDefaultOptions"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            IList<CultureInfo> supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("en-US"),
                new CultureInfo("it-IT"),
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("it-IT"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
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

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

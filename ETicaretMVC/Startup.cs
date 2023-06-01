using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretMVC
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
            services.AddScoped<INetflixService, NetflixManager>();
            services.AddScoped<INetflixDal, EfNetflixDal>();

            services.AddScoped<ISteamService, SteamManager>();
            services.AddScoped<ISteamDal, EfSteamDal>();

            services.AddScoped<IITunesService, ITunesManager>();
            services.AddScoped<IITunesDal, EfITunesDal>();

            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDal, EfAdminDal>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

            services.AddScoped<IAdresService, AdresManager>();
            services.AddScoped<IAdresDal, EfAdresDal>();

            services.AddScoped<IHomePageService, HomePageManager>();
            services.AddScoped<IHomePageDal, EfHomePageDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<IHomeService, HomeManager>();
            services.AddScoped<IHomeDal, EfHomeDal>();

            services.AddScoped<ISignUpService, SignUpManager>();
            services.AddScoped<ISignUpDal, EfSignUpDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<IBasketDal, EfBasketDal>();

            services.AddControllersWithViews();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

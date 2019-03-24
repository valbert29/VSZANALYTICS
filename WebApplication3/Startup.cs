﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication3.Models;
using VSZANAL.Models;

namespace WebApplication3
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
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<RUNContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<RUNContext>(opt => opt.UseInMemoryDatabase());
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });
            services.AddDistributedMemoryCache();
            services.AddSession();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<WEBContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WEBContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseSession();
            //string login = HttpContext.User.Identity.Name;

            //var cntx = app.ApplicationServices.GetService<RUNContext>();
            //app.Run(async (context) =>
            //{

            //    User user = await cntx.Users.FirstOrDefaultAsync(u => u.Login == login);

            //    if (context.Session.Keys.Contains("person"))
            //    {
            //        User person = context.Session.Get<User>("person");
            //        await context.Response.WriteAsync($"Hello {person.Role.Name}");
            //    }
            //    else
            //    {
            //        User person = user;
            //        context.Session.Set<User>("person", person);
            //        await context.Response.WriteAsync($"Hello {person.Role.Name}");
            //    }
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            
        }
    }
}

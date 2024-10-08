﻿using Microsoft.EntityFrameworkCore;

namespace WSR_SESSION1
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WSRDbContext>(options =>
                options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "patients",
                    pattern: "patients/{action=Index}/{id?}",
                    defaults: new { controller = "Patients" });

                endpoints.MapControllerRoute(
                    name: "hospitalizations",
                    pattern: "hospitalizations/{action=Index}/{id?}",
                    defaults: new { controller = "Hospitalizations" });
            });
        }
    }
}
using BookStoreMvcCoreWebApp.Data;
using BookStoreMvcCoreWebApp.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer());
           
            services.AddControllersWithViews();

            services.AddScoped<Book_Repository, Book_Repository>();
            services.AddScoped<Language_Repository, Language_Repository>();

            services.AddRazorPages().AddViewOptions(options=> {

                options.HtmlHelperOptions.ClientValidationEnabled = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions() { 
            
                FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
                RequestPath= "/MyStaticFiles"
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
        
                    //  await context.Response.WriteAsync("Hello World!");
                    //await context.Response.WriteAsync(env.EnvironmentName);
                    //endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name:"Default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                    );

            });
        }
    }
}

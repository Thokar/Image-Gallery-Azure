using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleGalleryApplication.Data;
using SimpleGalleryApplication.Service;

namespace SimpleGalleryApplication
{
  public class Startup
  {

    public IHostingEnvironment _environment;

    public Startup(IConfiguration configuration, IHostingEnvironment env)
    {
      Configuration = configuration;
      _environment = env;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // have a look here asp net core settings
      // https://blogs.msdn.microsoft.com/waws/2018/06/12/asp-net-core-settings-for-azure-app-service/
      // and this
      // https://blogs.msdn.microsoft.com/benjaminperkins/2017/06/21/asp-net-core-with-entity-framework-core-aspnetcore_environment/

      string constring;
      if (this._environment.IsDevelopment())
      {
        constring = Configuration.GetConnectionString("DefaultConnection");
      }
      else
      {
        constring = Configuration.GetConnectionString("ProdConnection");
      }

      services.AddDbContext<SimpleImageGalleryDbContext>(options => 
        options.UseSqlServer(constring));

      services.AddScoped<IImageService, ImageService>();

      services.Configure<CookiePolicyOptions>(options =>
      {
              // This lambda determines whether user consent for non-essential cookies is needed for a given request.
              options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      // update database
      //using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
      //{
      //  scope.ServiceProvider.GetService<SimpleImageGalleryDbContext>().Database.Migrate();
      //}

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
      app.UseCookiePolicy();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  //template: "{controller=Home}/{action=Index}/{id?}");
                  template: "{controller=Gallery}/{action=Index}/{id?}");
    });
    }
  }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGalleryApplication.Data.Seeder
{
  public static class IWebHostExtensions
  {
    public static IWebHost SeedData(this IWebHost host)
    {
      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        var context = scope.ServiceProvider.GetService<SimpleImageGalleryDbContext>();

        SimpleGalleryApplication.Data.Seeder.ImageSeeder.SeedImages(context);
      }
      return host;
    }
  }
}

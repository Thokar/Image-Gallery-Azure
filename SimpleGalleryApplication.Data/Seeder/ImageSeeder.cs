using Microsoft.EntityFrameworkCore;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGalleryApplication.Data.Seeder
{
  public static class ImageSeeder
  {
    public static void SeedImages(SimpleImageGalleryDbContext context)
    {
      context.Database.Migrate();

      foreach (var img in context.GalleryImages)
      {
        context.GalleryImages.Remove(img);
      }
      context.SaveChanges();

      if (!context.GalleryImages.Any())
      {
        // The table is empty

        var imageList = new List<GalleryImage>();
        var hikingImageTags = new List<ImageTag>();
        var cityImageTags = new List<ImageTag>();

        var tag1 = new ImageTag() { Description = "boat" };
        var tag2 = new ImageTag() { Description = "sailing" };
        var tag3 = new ImageTag() { Description = "skate" };

        hikingImageTags.Add(tag1);
        cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

        imageList.Add(new GalleryImage
        {
          Title = "My new Boat",
          Created = DateTime.Now,
          Url = @"/images/boat1.jpeg",
          ImageTags = hikingImageTags
        });
        imageList.Add(new GalleryImage
        {
          Title = "out Sailing",
          Created = DateTime.Now,
          Url = @"/images/boat2.jpeg",
          ImageTags = hikingImageTags
        });
        imageList.Add(new GalleryImage
        {
          Title = "My new Boat",
          Created = DateTime.Now,
          Url = @"/images/boat3.jpeg",
          ImageTags = cityImageTags
        });

        imageList.Add(new GalleryImage
        {
          Title = "Skatpark",
          Created = DateTime.Now,
          Url = @"/images/skate1.jpeg",
          ImageTags = hikingImageTags
        });
        imageList.Add(new GalleryImage
        {
          Title = "Skateboarding",
          Created = DateTime.Now,
          Url = @"/images/skate2.jpeg",
          ImageTags = hikingImageTags
        });
        imageList.Add(new GalleryImage
        {
          Title = "Skating",
          Created = DateTime.Now,
          Url = @"/images/skate3.jpeg",
          ImageTags = cityImageTags
        });

        foreach (GalleryImage image in imageList)
          context.GalleryImages.Add(image);

        context.SaveChanges();

      }
    }
  }
}

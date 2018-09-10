using Microsoft.EntityFrameworkCore;
using SimpleGalleryApplication.Data;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleGalleryApplication.Service
{
  public class ImageService : IImage
  {
    private readonly SimpleImageGalleryDbContext _ctx;
    public ImageService(SimpleImageGalleryDbContext context)
    {
      _ctx = context;
    }
    public IEnumerable<GalleryImage> GetAll()
    {
      return _ctx.GalleryImages.Include(img => img.ImageTags);
    }

    public GalleryImage GetById(int id)
    {
      //return _ctx.GalleryImages.Find(id);
      return GetAll().Where(img => img.ID == id).First();
    }

    public IEnumerable<GalleryImage> GetWithTag(string tag)
    {
      return GetAll().Where(img => 
        img.ImageTags
        .Any(t => t.Description == tag));
    }

    public object GetBlobContainer(string azureConnectionString, string v)
    {
      //var storageAccount = CloudStorageAccount.Parse();

      return new object();
    }
  }
}

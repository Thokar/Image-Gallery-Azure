using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using SimpleGalleryApplication.Data;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleGalleryApplication.Service
{
  public class ImageService : IImageService
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

    public CloudBlobContainer GetBlobContainer(string azureConnectionString, string containerName)
    {
      var storageAccount = CloudStorageAccount.Parse(azureConnectionString);
      var blocbClient = storageAccount.CreateCloudBlobClient();

      return blocbClient.GetContainerReference(containerName);
    }
    public Task SetImage(string title, string tags, Uri uri)
    {
      var image = new GalleryImage()
      {
        Title = title,
        ImageTags = ParseTags(tags).ToList<ImageTag>(),
        Url = uri.AbsoluteUri,
        Created = DateTime.Now
      };

      _ctx.GalleryImages.Add(image);
      return _ctx.SaveChangesAsync();
    }
    public IEnumerable<ImageTag> ParseTags(string tags)
    {
      var tagList = tags.Split(",").ToList().Select(tag => new ImageTag { Description = tag });

      return tagList;
    }
  }
}

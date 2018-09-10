using Microsoft.WindowsAzure.Storage.Blob;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleGalleryApplication.Data
{
  public interface IImageService
  {
    IEnumerable<GalleryImage> GetAll();
    IEnumerable<GalleryImage> GetWithTag(string tag);
    GalleryImage GetById(int id);
    CloudBlobContainer GetBlobContainer(string azureConnectionString, string containerName);
    Task SetImage(string title, string tags, Uri uri);
    IEnumerable<ImageTag> ParseTags(string tags);
  }
}

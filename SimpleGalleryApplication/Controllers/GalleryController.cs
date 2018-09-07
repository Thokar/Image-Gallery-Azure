using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleGalleryApplication.Data.Models;
using SimpleGalleryApplication.Models;

namespace SimpleGalleryApplication.Controllers
{
  public class GalleryController : Controller
  {
    public IActionResult Index()
    {
      var hikingImageTags = new List<ImageTag>();
      var cityImageTags = new List<ImageTag>();
      var imageList = new List<GalleryImage>();

      var tag1 = new ImageTag() { Description = "Adventure", Id = 1 };
      var tag2 = new ImageTag() { Description = "Urban", Id = 2 };
      var tag3 = new ImageTag() { Description = "New York", Id = 3 };

      hikingImageTags.Add(tag1);
      cityImageTags.AddRange(new List<ImageTag> { tag2, tag2 });

      imageList.Add(new GalleryImage {
        Title = "Hiking Trip",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/372098/pexels-photo-372098.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = hikingImageTags });
      imageList.Add(new GalleryImage {
        Title = "On the trail",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/1183986/pexels-photo-1183986.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = hikingImageTags });
      imageList.Add(new GalleryImage {
        Title = "DownTown",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/733778/pexels-photo-733778.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = cityImageTags });

      var model = new GalleryIndexModel()
      {
        Images = imageList,
        SearchQuery = string.Empty
        
      };
      return View(model);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;

namespace SimpleGalleryApplication.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
      var imageList = new List<GalleryImage>();
      var hikingImageTags = new List<ImageTag>();
      var cityImageTags = new List<ImageTag>();

      var tag1 = new ImageTag() { Description = "Adventure", Id = 1 };
      var tag2 = new ImageTag() { Description = "Urban", Id = 2 };
      var tag3 = new ImageTag() { Description = "New York", Id = 3 };

      hikingImageTags.Add(tag1);
      cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

      imageList.Add(new GalleryImage
      {
        Title = "Hiking Trip",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/372098/pexels-photo-372098.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = hikingImageTags
      });
      imageList.Add(new GalleryImage
      {
        Title = "On the trail",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/1183986/pexels-photo-1183986.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = hikingImageTags
      });
      imageList.Add(new GalleryImage
      {
        Title = "DownTown",
        Created = DateTime.Now,
        Url = @"https://images.pexels.com/photos/733778/pexels-photo-733778.jpeg?auto=compress&cs=tinysrgb&h=750&w=1260",
        ImageTags = cityImageTags
      });
    }
    }
}

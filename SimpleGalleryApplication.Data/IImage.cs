﻿using SimpleGalleryApplication.Data.Models;
using System.Collections.Generic;

namespace SimpleGalleryApplication.Data
{
  public interface IImage
  {
    IEnumerable<GalleryImage> GetAll();
    IEnumerable<GalleryImage> GetWithTag(string tag);
    GalleryImage GetById(int id);
  }
}

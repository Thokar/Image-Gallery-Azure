﻿using SimpleGalleryApplication.Data.Models;
using System.Collections.Generic;

namespace SimpleGalleryApplication.Models
{
  public class GalleryIndexModel
  {
    public IEnumerable<GalleryImage> Images { get; set; }
    public string SearchQuery { get; set; }
  }
}

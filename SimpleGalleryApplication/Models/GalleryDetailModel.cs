﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleGalleryApplication.Models
{
  public class GalleryDetailModel
  {
    public int Id { get; set; }
    public string Title{ get; set; }
    public DateTime Created { get; set; }
    public string Url { get; set; }

    public IEnumerable<string> Tags { get; set; }
  }
}

using Microsoft.EntityFrameworkCore;
using SimpleGalleryApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleGalleryApplication.Data
{
  public class SimpleImageGalleryDbContext: DbContext
  {
    public SimpleImageGalleryDbContext (DbContextOptions options) : base(options)
    {
    }
    public DbSet<GalleryImage> GalleryImages { get; set; }
    public DbSet<ImageTag> ImageTage { get; set; }
  }
}

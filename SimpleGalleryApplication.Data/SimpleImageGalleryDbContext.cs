using Microsoft.EntityFrameworkCore;
using SimpleGalleryApplication.Data.Models;
using System;

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

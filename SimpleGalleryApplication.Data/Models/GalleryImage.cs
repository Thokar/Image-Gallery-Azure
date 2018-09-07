using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGalleryApplication.Data.Models
{
  public class GalleryImage
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime Created { get; set; }
    public string Url { get; set; }
    public virtual IEnumerable<ImageTag> ImageTags { get; set; }
  }
}

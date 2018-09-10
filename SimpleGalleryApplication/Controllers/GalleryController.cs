using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SimpleGalleryApplication.Data;
using SimpleGalleryApplication.Models;

namespace SimpleGalleryApplication.Controllers
{
  public class GalleryController : Controller
  {
    private readonly IImageService _imageService;

    public GalleryController(IImageService imageService)
    {
      _imageService = imageService;
    }

    public IActionResult Index()
    {
      var imageList = _imageService.GetAll();

      var model = new GalleryIndexModel()
      {
        Images = imageList,
        SearchQuery = string.Empty
        
      };
      return View(model);
    }

    public IActionResult Detail(int id)
    {
      var image = _imageService.GetById(id);

      var model = new GalleryDetailModel()
      {
        Id = image.ID,
        Title = image.Title,
        Created = image.Created,
        Url = image.Url,
        Tags = image.ImageTags.Select(t => t.Description).ToList()

      };

      return View(model);
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleGalleryApplication.Models;

namespace SimpleGalleryApplication.Controllers
{
  public class ImageController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Upload()
    {
      var model = new UploadImageModel()
      {
      };
      return View();
    }

    [HttpPost]
    public IActionResult UploadNewImage()
    {
      return Ok();
    }
  }
}
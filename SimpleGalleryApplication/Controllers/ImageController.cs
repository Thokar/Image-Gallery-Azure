using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SimpleGalleryApplication.Models;
using SimpleGalleryApplication.Service;

namespace SimpleGalleryApplication.Controllers
{
  public class ImageController : Controller
  {
    private IConfiguration _config;
    private ImageService imageService;
    private string AzureConnectionString { get; }

    private ImageController(IConfiguration config, ImageService imageService)
    {
      this._config = config;
      this.AzureConnectionString = config["AzureStorageConnectionString"];
      this.imageService = imageService;
    }

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
      //return Ok();

      var container = this.imageService.GetBlobContainer(AzureConnectionString, "images");

      return Ok();
    }
  }
}
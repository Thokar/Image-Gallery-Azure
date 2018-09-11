using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using SimpleGalleryApplication.Data;
using SimpleGalleryApplication.Models;
using SimpleGalleryApplication.Service;

namespace SimpleGalleryApplication.Controllers
{
  public class ImageController : Controller
  {
    private readonly IConfiguration _config;
    private readonly IImageService imageService;
    private string AzureConnectionString { get; }

    public ImageController(IConfiguration config, IImageService imageService)
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
    public async Task<IActionResult> UploadNewImage(IFormFile file, string title, string tags)
    {
      var container = this.imageService.GetBlobContainer(AzureConnectionString, "images");
      var content = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
      var fileName = content.FileName.ToString().Replace('"', ' ').Trim();

      // get a reference to a block blob 
      var blockBlock = container.GetBlockBlobReference(fileName);
      await blockBlock.UploadFromStreamAsync(file.OpenReadStream());
      await imageService.SetImage(title, tags, blockBlock.Uri);

      return RedirectToAction("Index", "Gallery");

      //return Ok();
    }
  }
}
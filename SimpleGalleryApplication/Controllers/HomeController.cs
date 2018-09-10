using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SimpleGalleryApplication.Models;

namespace SimpleGalleryApplication.Controllers
{
  public class HomeController : Controller
  {
    public IConfiguration config { get; set; }
    public HomeController(IConfiguration config)
    {
      this.config = config;
    }
    public IActionResult Index()
    {
      ViewData["DefaultConnection"] = config["DefaultConnection"];
      ViewData["ProdConnection"] = config["ProdConnection"];

      ViewData["AzureStorageConnectionString"] = config["AzureStorageConnectionString"];

      ViewData["DefaultConnection.GetConnectionString"] = config.GetConnectionString("DefaultConnection");
      ViewData["ProdConnection.GetConnectionString"] = config.GetConnectionString("ProdConnection");

      ViewData["AzureStorageConnectionString.GetConnectionString"] = config.GetConnectionString("AzureStorageConnectionString");


      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RossetiWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;

namespace RossetiWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly ApplicationContext db;
        readonly IWebHostEnvironment _appEnvironment;

        public HomeController(ApplicationContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAscilogram(int AscilogramId)
        {
             return View();
        }

        [HttpPost]
        public IActionResult CreateAscilogram(Ascillogram ascilogram)
        {
            db.Ascillograms.Add(ascilogram);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public async Task<IActionResult> Create(IFormFile uploadedFile)
        //{
        //    if (uploadedFile != null)
        //    {
        //        // путь к папке Files
        //        string path = "/image/" + uploadedFile.FileName;
        //        // сохраняем файл в папку Files в каталоге wwwroot
        //        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        //        {
        //            await uploadedFile.CopyToAsync(fileStream);
        //        }
        //        FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
        //        db.Files.Add(file);
        //        db.SaveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}
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

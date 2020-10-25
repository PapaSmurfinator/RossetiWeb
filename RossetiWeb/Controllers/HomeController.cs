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
using RossetiWeb.Mod;

namespace RossetiWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly auradbContext db;
        readonly IWebHostEnvironment _appEnvironment;

        public HomeController(auradbContext context, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var x = db._3version.ToList();
            foreach(var i in x)
            {
                if(i != null) {
                    if (i.UaВл330Дерб330KV > 0.0)
                    {
                        if (i.UaВл330Дерб330KV - 10 < 0)
                        {
                            ViewData["Message"] = "Трёхфазное короткое замыкание";
                        }
                        else
                        {
                            if (i.UbВл33009330KV - 10 < 0 || i.UaВл330Дерб330KV - 10 > 0)
                            {
                                ViewData["Message"] = "Однофазное короткое замыкание";
                            }
                            else
                            {
                                ViewData["Message"] = "Двухфазное короткое замыкание";
                            }
                        }
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateAscillogram()
        {
            //ViewData["AscillogramCategory"] = new SelectList(db.AscillogramCategories, "Id", "Name"); 
            return View();
        }

        [HttpPost]
        public IActionResult CreateAscillogram([Bind("Id,Name,AscillogramCategoryId")] Ascillogram ascillogram)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Ascillograms.Add(ascillogram);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewData["AscillogramCategory"] = new SelectList(db.AscillogramCategories, "Id", "Name", ascillogram.AscillogramCategoryId);
            //return View(ascillogram);
            return null;
        }

        [HttpGet]
        public IActionResult CreateAscillogramCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAscillogramCategory(AscillogramCategory ascillogramcategory)
        {
            //db.AscillogramCategories.Add(ascillogramcategory);
            //db.SaveChanges();
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

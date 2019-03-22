﻿using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
            return Content(User.Identity.Name);
        }

        RUNContext _context;
        IHostingEnvironment _appEnvironment;
        public HomeController(RUNContext context, IHostingEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFileCollection uploads)
        {
            foreach (var uploadedFile in uploads)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Id==1);
                UserFile file = new UserFile { Name = uploadedFile.FileName, Path = path, Time = DateTime.Now, User=user };
                _context.Files.Add(file);
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        

        public IActionResult ProfilePage()
        {
            return View("../Profile/ProfilePage");
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace VSZANAL.Controllers
{
    public class ProfieController : Controller
    {
        private readonly RUNContext _context;
        IHostingEnvironment _appEnvironment;

        public ProfieController(RUNContext context)
        {
            _context = context;
        }

        public IActionResult ProfilePage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAvatar(IFormFileCollection uploads)
        {
            foreach (var uploadedFile in uploads)
            {
                // путь к папке Files
                string path = "/Avatar/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Id == 1);
                UserFile file = new UserFile { Name = uploadedFile.FileName, Path = path, Time = DateTime.Now, User = user };
                _context.Files.Add(file);
            }
            _context.SaveChanges();

            return RedirectToAction("ProfilePage");
        }

        // GET: UserFiles
        public async Task<IActionResult> Index()
        {
            var rUNContext = _context.Files.Include(u => u.User);
            return View(await rUNContext.ToListAsync());    
        }

        // GET: UserFiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFile = await _context.Files
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFile == null)
            {
                return NotFound();
            }

            return View(userFile);
        }

        // GET: UserFiles/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UserFiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Path,Time,UserId")] UserFile userFile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userFile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userFile.UserId);
            return View(userFile);
        }

        // GET: UserFiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFile = await _context.Files.FindAsync(id);
            if (userFile == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userFile.UserId);
            return View(userFile);
        }

        // POST: UserFiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Path,Time,UserId")] UserFile userFile)
        {
            if (id != userFile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userFile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserFileExists(userFile.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userFile.UserId);
            return View(userFile);
        }

        // GET: UserFiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userFile = await _context.Files
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userFile == null)
            {
                return NotFound();
            }

            return View(userFile);
        }

        // POST: UserFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userFile = await _context.Files.FindAsync(id);
            _context.Files.Remove(userFile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserFileExists(int id)
        {
            return _context.Files.Any(e => e.Id == id);
        }
    }
}

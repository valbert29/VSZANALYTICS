using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace VSZANAL.Controllers
{
    public class UserFilesController : Controller
    {
        private readonly RUNContext _context;

        public UserFilesController(RUNContext context)
        {
            _context = context;
        }

        // GET: UserFiles
        public async Task<IActionResult> Index()
        {
            var login = HttpContext.Response.HttpContext.User.Identity.Name;
            User user = await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
            ViewBag.login = user.Id;
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

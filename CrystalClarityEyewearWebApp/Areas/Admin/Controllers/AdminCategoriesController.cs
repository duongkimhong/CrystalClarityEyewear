using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrystalClarityEyewearWebApp.Models;
using AppContext = CrystalClarityEyewearWebApp.Models.AppContext;

namespace CrystalClarityEyewearWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoriesController : Controller
    {
        private readonly AppContext _context;

        public AdminCategoriesController(AppContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminCategories
        public async Task<IActionResult> Index()
        {
              return _context.Categories != null ? 
                          View(await _context.Categories.ToListAsync()) :
                          Problem("Entity set 'AppContext.Categories'  is null.");
        }

        // GET: Admin/AdminCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Admin/AdminCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,Description,Icon,SeoTitle,SeoDescription,SeoKeywords,Position,CreatedBy,CreateDate,ModifiedDate,ModifiedBy")] Category category)
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreateDate = DateTime.Now;
                category.ModifiedDate = DateTime.Now;
                category.Alias = Models.Filter.FilterChar(category.Title);
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/AdminCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/AdminCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Icon,SeoTitle,SeoDescription,SeoKeywords,Position,CreatedBy,CreateDate,ModifiedDate,ModifiedBy")] Category category)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (int id, Category category)
        {
            //if (id != category.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(category);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!CategoryExists(category.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(category);
            if (ModelState.IsValid)
            {
                try
                {
                    category.ModifiedDate = DateTime.Now;
                    category.Alias = Models.Filter.FilterChar(category.Title);
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            // Nếu ModelState không hợp lệ, thêm thông báo lỗi cho từng trường không hợp lệ
            foreach (var entry in ModelState.Values)
            {
                foreach (var error in entry.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.ErrorMessage);
                }
            }

            return View(category);
        }

        // GET: Admin/AdminCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Admin/AdminCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'AppContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
          return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

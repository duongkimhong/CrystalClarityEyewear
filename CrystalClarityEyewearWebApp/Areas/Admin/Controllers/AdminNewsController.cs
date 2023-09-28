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
    public class AdminNewsController : Controller
    {
        private readonly AppContext _context;
        private readonly IWebHostEnvironment _environment;

        public AdminNewsController(AppContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/AdminNews
        public async Task<IActionResult> Index()
        {
            var appContext = _context.News.Include(n => n.Category);
            return View(await appContext.ToListAsync());
        }

        // GET: Admin/AdminNews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/AdminNews/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title");
            return View();
        }

        // POST: Admin/AdminNews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //public async Task<IActionResult> Create([Bind("Id,Title,Description,Detail,Image,Alias,CategoryId,SeoTitle,SeoDescription,SeoKeywords,CreatedBy,CreateDate,ModifiedDate,ModifiedBy")] News news)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news)
        {
            if (ModelState.IsValid)
            {
                if (news.CoverImage != null && news.CoverImage.Length > 0)
                {
                    // Kiểm tra dung lượng tệp tải lên
                    if (news.CoverImage.Length <= 10 * 1024 * 1024) // 10MB
                    {
                        string folder = "Uploads/News";
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(news.CoverImage.FileName);
                        string filePath = Path.Combine(_environment.WebRootPath, folder, uniqueFileName);

                        // Tạo thư mục nếu không tồn tại
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, folder));

                        // Lưu tệp tải lên vào máy chủ
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await news.CoverImage.CopyToAsync(stream);
                        }

                        // Cập nhật đường dẫn đến tệp tải lên
                        news.Image = "/" + folder + "/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("CoverImage", "Dung lượng tệp tải lên quá lớn (tối đa 10MB).");
                        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", news.CategoryId);
                        return View(news);
                    }
                }

                news.CreateDate = DateTime.Now;
                news.ModifiedDate = DateTime.Now;
                news.CategoryId = 2;
                news.Alias = Models.Filter.FilterChar(news.Title);
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", news.CategoryId);
            return View(news);
        }

        // GET: Admin/News/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }

            // Đặt giá trị của CoverImage vào ViewBag để hiển thị trong View
            ViewBag.CoverImageFileName = news.CoverImage;

            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", news.CategoryId);
            return View(news);
        }


        // POST: Admin/AdminNews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[FromForm] News news)
        {
            if (id != news.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (news.CoverImage != null && news.CoverImage.Length > 0)
                {
                    // Kiểm tra dung lượng tệp tải lên
                    if (news.CoverImage.Length <= 10 * 1024 * 1024) // 10MB
                    {
                        string folder = "Uploads/News";
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(news.CoverImage.FileName);
                        string filePath = Path.Combine(_environment.WebRootPath, folder, uniqueFileName);

                        // Tạo thư mục nếu không tồn tại
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, folder));

                        // Lưu tệp tải lên vào máy chủ
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await news.CoverImage.CopyToAsync(stream);
                        }

                        // Cập nhật đường dẫn đến tệp tải lên
                        news.Image = "/" + folder + "/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("CoverImage", "Dung lượng tệp tải lên quá lớn (tối đa 10MB).");
                        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", news.CategoryId);
                        return View(news);
                    }
                }

                news.ModifiedDate = DateTime.Now;
                news.Alias = Models.Filter.FilterChar(news.Title);
                _context.Update(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", news.CategoryId);
            return View(news);
        }


        // GET: Admin/AdminNews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/AdminNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.News == null)
            {
                return Problem("Entity set 'AppContext.News'  is null.");
            }
            var news = await _context.News.FindAsync(id);
            if (news != null)
            {
                _context.News.Remove(news);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
          return (_context.News?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

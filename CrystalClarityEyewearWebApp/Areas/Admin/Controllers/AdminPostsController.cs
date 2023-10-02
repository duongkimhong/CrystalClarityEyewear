using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrystalClarityEyewearWebApp.Models;
using Microsoft.Extensions.Hosting;
using X.PagedList;

namespace CrystalClarityEyewearWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPostsController : Controller
    {
        private readonly Models.AppContext _context;
        private readonly IWebHostEnvironment _environment;

        public AdminPostsController(Models.AppContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Admin/AdminPosts
        public async Task<IActionResult> Index(int? page)
        {
            // Số lượng mục trên mỗi trang
            int pageSize = 1;

            // Trang hiện tại (nếu không được đặt, mặc định là 1)
            int pageNumber = (page ?? 1);

            var appContext = _context.Posts.Include(p => p.Category);
            var pagedListPosts = await appContext.ToPagedListAsync(pageNumber, pageSize);

            return View(pagedListPosts);
        }

        // GET: Admin/AdminPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/AdminPosts/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title");
            return View();
        }

        // POST: Admin/AdminPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] Post post)
        {
            
            if (ModelState.IsValid)
            {
                if (post.CoverImage != null && post.CoverImage.Length > 0)
                {
                    // Kiểm tra dung lượng tệp tải lên
                    if (post.CoverImage.Length <= 10 * 1024 * 1024) // 10MB
                    {
                        string folder = "Uploads/Post";
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(post.CoverImage.FileName);
                        string filePath = Path.Combine(_environment.WebRootPath, folder, uniqueFileName);

                        // Tạo thư mục nếu không tồn tại
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, folder));

                        // Lưu tệp tải lên vào máy chủ
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await post.CoverImage.CopyToAsync(stream);
                        }

                        // Cập nhật đường dẫn đến tệp tải lên
                        post.Image = "/" + folder + "/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("CoverImage", "Dung lượng tệp tải lên quá lớn (tối đa 10MB).");
                        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", post.CategoryId);
                        return View(post);
                    }
                }

                post.CreateDate = DateTime.Now;
                post.ModifiedDate = DateTime.Now;
                //post.CategoryId = 2;
                post.Alias = Models.Filter.FilterChar(post.Title);
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", post.CategoryId);
            return View(post);
        }

        // GET: Admin/AdminPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", post.CategoryId);
            return View(post);
        }

        // POST: Admin/AdminPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [FromForm] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (post.CoverImage != null && post.CoverImage.Length > 0)
                {
                    // Kiểm tra dung lượng tệp tải lên
                    if (post.CoverImage.Length <= 10 * 1024 * 1024) // 10MB
                    {
                        string folder = "Uploads/Post";
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(post.CoverImage.FileName);
                        string filePath = Path.Combine(_environment.WebRootPath, folder, uniqueFileName);

                        // Tạo thư mục nếu không tồn tại
                        Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, folder));

                        // Lưu tệp tải lên vào máy chủ
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await post.CoverImage.CopyToAsync(stream);
                        }

                        // Cập nhật đường dẫn đến tệp tải lên
                        post.Image = "/" + folder + "/" + uniqueFileName;
                    }
                    else
                    {
                        ModelState.AddModelError("CoverImage", "Dung lượng tệp tải lên quá lớn (tối đa 10MB).");
                        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", post.CategoryId);
                        return View(post);
                    }
                }
                post.ModifiedDate = DateTime.Now;
                post.Alias = Models.Filter.FilterChar(post.Title);
                _context.Update(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title", post.CategoryId);
            return View(post);
        }

        // GET: Admin/AdminPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/AdminPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Posts == null)
            {
                return Problem("Entity set 'AppContext.Posts'  is null.");
            }
            var post = await _context.Posts.FindAsync(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
          return (_context.Posts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

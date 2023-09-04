using CrystalClarityEyewearWebApp.Models;
using CrystalClarityEyewearWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CrystalClarityEyewearWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminAccountsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [Route("~/Admin/Accounts")]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users
                .Select(u => new AccountViewModel
                {
                    Id = u.Id,
                    Username = u.UserName,
                    Email = u.Email,
                    IsLockedOut = u.LockoutEnabled && u.LockoutEnd > DateTimeOffset.UtcNow
                })
                .ToListAsync();

            return View(users);
        }
    }
}

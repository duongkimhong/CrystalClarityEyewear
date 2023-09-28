using Microsoft.AspNetCore.Mvc;
using AppContext = CrystalClarityEyewearWebApp.Models.AppContext;

namespace CrystalClarityEyewearWebApp.Areas.Admin.Controllers
{
	public class AdminProductsController : Controller
	{
		private readonly AppContext _context;
		public AdminProductsController(AppContext context)
		{
			_context = context;
		}
        public IActionResult Index(int? page)
		{
			var item = _context.Products.OrderByDescending(x => x.Id);
			var pageSize = 10;
			if (page == null)
			{
				page = 1;
			}
			
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopify.Data;

namespace Shopify.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext _context;
        //injecting the dbcontext
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.categories.AsNoTracking().ToList();
            return View(categories);
        }
    }
}

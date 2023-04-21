using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project_SW.Data;

namespace project_SW.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}

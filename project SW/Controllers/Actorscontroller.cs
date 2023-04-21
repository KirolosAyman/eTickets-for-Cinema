using Microsoft.AspNetCore.Mvc;
using project_SW.Data;

namespace project_SW.Controllers
{
    public class Actorscontroller : Controller
    {
        private readonly AppDbContext _context;
        public Actorscontroller(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}

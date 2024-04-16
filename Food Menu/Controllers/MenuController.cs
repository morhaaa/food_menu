using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Food_Menu.Data;
using Food_Menu.Models;

namespace Food_Menu.Controllers
{
    public class MenuController : Controller
    {
        private readonly MenuContext _context;
        
        public MenuController(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishes.ToListAsync());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using midandfeed.Models;
using midandfeed.Data;
using Microsoft.EntityFrameworkCore;

namespace midandfeed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.News.ToListAsync());

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Stránka pre fanúšikov League of Legends";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Kontakt support";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

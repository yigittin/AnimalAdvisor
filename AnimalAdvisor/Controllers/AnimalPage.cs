using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimalAdvisor.Data;
using AnimalAdvisor.Models;

namespace AnimalAdvisor.Controllers
{
    public class AnimalPage : Controller
    {
        private readonly ApplicationDbContext _context;
        public int _id;
        public AnimalPage(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AnimalPage
       /* public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Animals.Include(a => a.Species);
            return View(await applicationDbContext.ToListAsync());
        }
       */
        public async Task<IActionResult> Index(int id)
        {
            var applicationDbContext = _context.Animals.Where(a=>a.Id==id).Include(a => a.Species);
            //var list = from x in applicationDbContext where x.Id == id select x;

            return View(await applicationDbContext.ToListAsync());
        }
        // GET: AnimalPage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animals
                .Include(a => a.Species)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

    }
}

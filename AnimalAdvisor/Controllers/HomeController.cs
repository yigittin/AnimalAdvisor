using AnimalAdvisor.Data;
using AnimalAdvisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace AnimalAdvisor.Controllers
{

   
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public int _animalId;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public int getAnimalId()
        {
            return _animalId;
        }
        public IActionResult Index()
        {
            var db = _context.Species.Include(f => f.Category);
            return View(db.ToList());
        }

        [HttpPost]
        public IActionResult Index(int animalId)
        {
            var db = _context.Animals.Where(f=>f.Id==animalId).Include(f => f.Species);
            return View(db.ToList());
        }

        public IActionResult Animals(string id)
        {
            int animalId = Int32.Parse(id);
            var db = _context.Animals.Where(f => f.SpeciesId == animalId).Include(f => f.Species);
            return View(db.ToList());           
        }

        public IActionResult GetId()
        {
            //string animalIds;
            //animalIds = Request.Form["animalId"];
            //animalId = Int32.Parse(animalIds);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

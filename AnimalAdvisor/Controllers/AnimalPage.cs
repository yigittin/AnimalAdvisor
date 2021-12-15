using AnimalAdvisor.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdvisor.Controllers
{
    public class AnimalPage : Controller
    {
        private ApplicationDbContext _context;

        public AnimalPage(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            

            return View();
        }
    }
}

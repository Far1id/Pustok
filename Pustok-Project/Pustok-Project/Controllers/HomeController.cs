using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pustok_Project.DAL;
using Pustok_Project.Models;
using Pustok_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Feature> features = _context.Features.ToList();


            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Features = features
            };

            return View(homeVM);
        }

       
    }
}

using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using System.Diagnostics;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }

        public IActionResult MovieDetail( )
        {
           return View();
        }
    }
}
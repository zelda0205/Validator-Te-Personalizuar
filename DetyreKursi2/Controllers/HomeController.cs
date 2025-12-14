using System.Diagnostics;
using DetyreKursi2.Models;
using Microsoft.AspNetCore.Mvc;

namespace DetyreKursi2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kursi kursi)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View("Details", kursi);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

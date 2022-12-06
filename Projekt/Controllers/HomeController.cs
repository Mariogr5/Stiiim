using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using System.Diagnostics;
namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        List<Gra> listagier;
        public HomeController()
        {
            listagier = new List<Gra>()
            {
                new Gra(1, "pasjans", "Logiczna", 20, "Fajna gra karciana", "Chess.jpg"),
                new Gra(2, "Szachy", "Logiczna", 30, "Fajna gra planszowa", "Chess.jpg"),
                new Gra(3, "pasjans", "Logiczna", 20, "Fajna gra karciana", "pasjans.jfif"),
                new Gra(4, "pasjans", "Logiczna", 20, "Fajna gra karciana", "pasjans.jfif"),
                new Gra(5, "pasjans", "Logiczna", 20, "Fajna gra karciana", "pasjans.jfif"),
                new Gra(5, "pasjans", "Logiczna", 20, "Fajna gra karciana", "pasjans.jfif"),
                new Gra(5, "pasjans", "Logiczna", 20, "Fajna gra karciana", "pasjans.jfif"),
            };
        }

        public IActionResult Index()
        {
            return View(listagier);
        }

        public IActionResult Privacy()
        {
            return View(listagier);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
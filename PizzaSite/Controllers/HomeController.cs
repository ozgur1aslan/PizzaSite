using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;
using System.Diagnostics;

namespace PizzaSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pizza()
        {
            IEnumerable<PizzasModel> objPizzasList = _db.Pizzas;
            return View(objPizzasList);
        }


        public IActionResult Drink()
        {
            IEnumerable<DrinksModel> objDrinksList = _db.Drinks;
            return View(objDrinksList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
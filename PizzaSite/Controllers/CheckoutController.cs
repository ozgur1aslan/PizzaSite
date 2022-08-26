using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;

namespace PizzaSite.Controllers
{
    public class CheckoutController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CheckoutController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var PizzasModelFromDb = _db.Pizzas.Find(id);

            if (PizzasModelFromDb == null)
            {
                return NotFound();
            }

            return View(PizzasModelFromDb);
        }



        public IActionResult ThankYou()
        {
            return View();
        }




    }
}

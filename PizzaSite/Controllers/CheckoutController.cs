using Microsoft.AspNetCore.Mvc;
using PizzaSite.Models;

namespace PizzaSite.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}

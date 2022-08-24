using Microsoft.AspNetCore.Mvc;

namespace PizzaSite.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomPizza()
        {
            return View();
        }
    }
}

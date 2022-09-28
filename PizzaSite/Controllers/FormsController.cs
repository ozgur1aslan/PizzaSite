using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;
using System.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace PizzaSite.Controllers
{
    public class FormsController : Controller
    {

        private readonly ApplicationDbContext _db;

        public FormsController(ApplicationDbContext db)
        {
            _db = db;
        }



        //Index GET
        public IActionResult Index()
        {
            return View();
        }



        //CustomPizza GET
        public IActionResult CustomPizza()
        {
            return View();
        }

        //CustomPizza POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomPizza(PizzasModel obj)
        {

            obj.ImageTitle = "Create";

            obj.FinalPrice = obj.BasePrice;

            if (obj.TomatoSauce == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Cheese == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Peperoni == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Mushroom == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Tuna == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Pineapple == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Ham == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }

            if (obj.Beef == true)
            {
                obj.FinalPrice = obj.FinalPrice + 2;
            }



            if (ModelState.IsValid)
            {
                
                return RedirectToAction("CustomCheckout", "Checkout", obj);
            }

            return View(obj);
        }






        //Complaint GET
        public IActionResult Complaint()
        {

            return View();
        }


        //Complaint POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Complaint(ComplaintModel obj)
        {

            obj.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            obj.Date = DateTime.UtcNow;

            //if (ModelState.IsValid)
            //{

            //}
            _db.Complaints.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Form sent successfully";
            return RedirectToAction("Index", "Home");


        }



        //Suggesstion GET
        public IActionResult Suggestion()
        {

            return View();
        }


        //Suggesstion POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Suggestion(SuggestionModel obj)
        {

            obj.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            obj.Date = DateTime.UtcNow;

            //if (ModelState.IsValid)
            //{

            //    _db.Suggestions.Add(obj);
            //    _db.SaveChanges();
            //    TempData["success"] = "Form sent successfully";
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    TempData["error"] = "Form didn't sent successfully";
            //    return RedirectToAction("Index");
            //}

            _db.Suggestions.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Form sent successfully";
            return RedirectToAction("Index", "Home");


        }
    }
}

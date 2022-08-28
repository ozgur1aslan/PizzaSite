using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;
using System.Security.Claims;

namespace PizzaSite.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PizzaList()
        {
            IEnumerable<OrderModel> objOrderModelList = _db.Orders;
            return View(objOrderModelList);
        }



        public IActionResult DrinkList()
        {
            IEnumerable<DrinksOrderModel> objDrinksOrderModelList = _db.DrinkOrders;
            return View(objDrinksOrderModelList);
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

            if (ModelState.IsValid)
            {
                
            }
            _db.Complaints.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Pizza updated successfully";
            return RedirectToAction("Index");

            
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

            if (ModelState.IsValid)
            {

            }
            _db.Suggestions.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Pizza updated successfully";
            return RedirectToAction("Index");


        }

    }
}

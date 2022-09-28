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

        //Checkout GET
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


        
        //Checkout POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout(PizzasModel obj)
        {

            //Random rnd = new Random();
            //int num = rnd.Next(34);

            //obj2.Id = num;


            OrderModel obj2 = new OrderModel();

            obj2.Id = 0;
            obj2.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            obj2.Date = DateTime.UtcNow;



            obj2.PizzasModelId = obj.Id;                  
            obj2.PizzasModelPizzaName = obj.PizzaName;
            obj2.PizzasModelFinalPrice = obj.FinalPrice;

            //obj2.TomatoSauce = obj.TomatoSauce;
            //obj2.Cheese = obj.Cheese;
            //obj2.Peperoni = obj.Peperoni;
            //obj2.Mushroom = obj.Mushroom;
            //obj2.Tuna = obj.Tuna;
            //obj2.Pineapple = obj.Pineapple;
            //obj2.Ham = obj.Ham;
            //obj2.Beef = obj.Beef;


            if (ModelState.IsValid)
            {
                _db.Orders.Add(obj2);
                _db.SaveChanges();
                TempData["success"] = "Ordered successfully";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = "Ordered unsuccessfully";
                return RedirectToAction("Index", "Home");
            }

            
        }


        //CheckoutDrink GET
        public IActionResult DrinkCheckout(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var DrinksModelFromDb = _db.Drinks.Find(id);

            if (DrinksModelFromDb == null)
            {
                return NotFound();
            }

            return View(DrinksModelFromDb);
        }

        //CheckoutDrink POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DrinkCheckout(DrinksOrderModel obj3, DrinksModel obj)
        {


            //Random rnd = new Random();
            //int num = rnd.Next(34);

            obj3.Id = 0;
            obj3.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            obj3.Date = DateTime.UtcNow;

            obj3.DrinksModelId = obj.Id;
            obj3.DrinksModelDrinkName = obj.DrinkName;
            obj3.DrinksModelFinalPrice = obj.FinalPrice;


            if (ModelState.IsValid)
            {

            }

            _db.DrinkOrders.Add(obj3);
            _db.SaveChanges();
            TempData["success"] = "Ordered successfully";
            return RedirectToAction("Index", "Home");
        }


        public IActionResult ThankYou()
        {
            return View();
        }




        //CustomCheckout GET
        public IActionResult CustomCheckout(PizzasModel? obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        //CustomCheckout POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomCheckoutPOST(PizzasModel obj)
        {

            CustomOrderModel obj2 = new CustomOrderModel();

            obj2.Id = 0;
            obj2.AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            obj2.Date = DateTime.UtcNow;

            obj2.PizzasModelPizzaName = obj.PizzaName;
            obj2.PizzasModelFinalPrice = obj.FinalPrice;

            obj2.TomatoSauce = obj.TomatoSauce;
            obj2.Cheese = obj.Cheese;
            obj2.Peperoni = obj.Peperoni;
            obj2.Mushroom = obj.Mushroom;
            obj2.Tuna = obj.Tuna;
            obj2.Pineapple = obj.Pineapple;
            obj2.Ham = obj.Ham;
            obj2.Beef = obj.Beef;


            if (ModelState.IsValid)
            {
                _db.CustomOrders.Add(obj2);
                _db.SaveChanges();
                TempData["success"] = "Ordered successfully";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = "Ordered unsuccessfully";
                return RedirectToAction("Index", "Home");
            }


        }
    }
}

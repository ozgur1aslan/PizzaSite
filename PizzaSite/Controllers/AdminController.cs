using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;
using System.Security.Claims;

namespace PizzaSite.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }



        //Index GET
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }




        //CreatePizza GET
        [Authorize(Roles = "Admin")]
        public IActionResult CreatePizza()
        {
            return View();
        }

        //CreatePizza POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePizza(PizzasModel obj)
        {
            //if (obj.Beef == obj.Pineapple)
            //{
            //    ModelState.AddModelError("CustomError", "You can't add beef and pineapple at the same time.");
            //}

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
                _db.Pizzas.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Pizza created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }






        //PizzaList GET
        [Authorize(Roles = "Admin")]
        public IActionResult PizzaList()
        {
            IEnumerable<PizzasModel> objPizzasModelList = _db.Pizzas;
            return View(objPizzasModelList);
        }





        //EditPizza GET
        [Authorize(Roles = "Admin")]
        public IActionResult EditPizza(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var PizzasModelFromDb = _db.Pizzas.Find(id);
            //var PizzasModelFromDbFirst = _db.Pizzas.FirstOrDefault(u=>u.Id == id);
            //var PizzasModelFromDbSingle = _db.Pizzas.SingleOrDefault(u => u.Id == id);

            if (PizzasModelFromDb == null)
            {
                return NotFound();
            }

            return View(PizzasModelFromDb);
        }


        //EditPizza POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPizza(PizzasModel obj)
        {
            //if (obj.Beef == obj.Pineapple)
            //{
            //    ModelState.AddModelError("CustomError", "You can't add beef and pineapple at the same time.");
            //}


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
                _db.Pizzas.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Pizza updated successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }



        //DeletePizza GET
        [Authorize(Roles = "Admin")]
        public IActionResult DeletePizza(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var PizzasModelFromDb = _db.Pizzas.Find(id);
            //var PizzasModelFromDbFirst = _db.Pizzas.FirstOrDefault(u=>u.Id == id);
            //var PizzasModelFromDbSingle = _db.Pizzas.SingleOrDefault(u => u.Id == id);

            if (PizzasModelFromDb == null)
            {
                return NotFound();
            }

            return View(PizzasModelFromDb);
        }


        //DeletePizza POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePizzaPOST(int? id)
        {
            var obj = _db.Pizzas.Find(id);
            if (obj == null)
            {
                return NotFound();
            }


            _db.Pizzas.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Pizza deleted successfully";
            return RedirectToAction("Index");


        }








        //CreateDrink GET
        [Authorize(Roles = "Admin")]
        public IActionResult CreateDrink()
        {
            return View();
        }

        //CreateDrink POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateDrink(DrinksModel obj)
        {
      

            if (ModelState.IsValid)
            {
                _db.Drinks.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Drink created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        //DrinkList GET
        [Authorize(Roles = "Admin")]
        public IActionResult DrinkList()
        {
            IEnumerable<DrinksModel> objDrinksModelList = _db.Drinks;
            return View(objDrinksModelList);
        }


        //EditDrink GET
        [Authorize(Roles = "Admin")]
        public IActionResult EditDrink(int? id)
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


        //EditPizza POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditDrink(DrinksModel obj)
        {


            if (ModelState.IsValid)
            {
                _db.Drinks.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Drink updated successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        //DeleteDrink GET
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteDrink(int? id)
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


        //DeleteDrink POST
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDrinkPOST(int? id)
        {
            var obj = _db.Drinks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }


            _db.Drinks.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Drink deleted successfully";
            return RedirectToAction("Index");


        }

    }
}

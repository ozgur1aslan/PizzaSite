using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;

namespace PizzaSite.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Create GET
        public IActionResult Create()
        {
            return View();
        }

        //Create POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PizzasModel obj)
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



        public IActionResult List()
        {
            IEnumerable<PizzasModel> objPizzasModelList = _db.Pizzas;
            return View(objPizzasModelList);
        }



        //Edit GET
        public IActionResult Edit(int? id)
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


        //Edit POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PizzasModel obj)
        {
            //if (obj.Beef == obj.Pineapple)
            //{
            //    ModelState.AddModelError("CustomError", "You can't add beef and pineapple at the same time.");
            //}


            if (ModelState.IsValid)
            {
                _db.Pizzas.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Pizza updated successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }



        //Delete GET
        public IActionResult Delete(int? id)
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


        //Delete POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
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

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaSite.Data;
using PizzaSite.Models;
using System.Dynamic;
using System.Security.Claims;
using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PizzaSite.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }


        //Index GET
        public IActionResult Index()
        {
            return View();
        }


        //PizzaOrdersList GET
        public IActionResult PizzaOrdersList()
        {

            //IEnumerable<OrderModel> objOrderModelList = _db.Orders;
            //IEnumerable<CustomOrderModel> objCustomOrderModelList = _db.CustomOrders;

            IEnumerable<OrderModel> objOrderModelList = _db.Orders.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            IEnumerable<CustomOrderModel> objCustomOrderModelList = _db.CustomOrders.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            

            dynamic mymodel = new ExpandoObject();
            mymodel.Orders = objOrderModelList;
            mymodel.CustomOrders = objCustomOrderModelList;

            
            return View(mymodel);
        }



        //DrinkOrdersList GET
        public IActionResult DrinkOrdersList()
        {
            IEnumerable<DrinksOrderModel> objDrinksOrderModelList = _db.DrinkOrders.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(objDrinksOrderModelList);
        }


        //SuggestionsList GET
        public IActionResult SuggestionsList()
        {
            IEnumerable<SuggestionModel> objSuggestionModelList = _db.Suggestions.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(objSuggestionModelList);
        }


        //ComplaintsList GET
        public IActionResult ComplaintsList()
        {
            IEnumerable<ComplaintModel> objComplaintModelList = _db.Complaints.Where(x => x.AspNetUsersId == User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(objComplaintModelList);
        }

    }
}

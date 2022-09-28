using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaSite.Models;

namespace PizzaSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PizzasModel> Pizzas { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<CustomOrderModel> CustomOrders { get; set; }

        public DbSet<DrinksModel> Drinks { get; set; }
        public DbSet<DrinksOrderModel> DrinkOrders { get; set; }

        public DbSet<ComplaintModel> Complaints { get; set; }
        public DbSet<SuggestionModel> Suggestions { get; set; }

        public DbSet<CounterModel> Counter { get; set; }

        public DbSet<AspNetUserModel> AspNetUsers { get; set; }

    }
}

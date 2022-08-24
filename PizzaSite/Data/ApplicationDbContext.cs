using Microsoft.EntityFrameworkCore;
using PizzaSite.Models;

namespace PizzaSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PizzasModel> Pizzas { get; set; }

    }
}

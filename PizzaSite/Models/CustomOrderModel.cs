using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class CustomOrderModel
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]

        public virtual AspNetUsers AspNetUsers { get; set; }


        public DateTime Date { get; set; }

        public string PizzasModelPizzaName { get; set; }
        [ForeignKey("PizzasModelPizzaName")]

        public int PizzasModelFinalPrice { get; set; }
        [ForeignKey("PizzasModelFinalPrice")]
        public virtual PizzasModel PizzasModel { get; set; }

        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

    }

}

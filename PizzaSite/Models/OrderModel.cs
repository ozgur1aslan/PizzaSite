using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class OrderModel
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]

        public virtual AspNetUsers AspNetUsers { get; set; }


        
        
        public string PizzasModelPizzaName { get; set; }
        [ForeignKey("PizzasModelPizzaName")]

        public int PizzasModelFinalPrice { get; set; }
        [ForeignKey("PizzasModelFinalPrice")]
        public int PizzasModelId { get; set; }
        [ForeignKey("PizzasModelId")]
        public virtual PizzasModel PizzasModel { get; set; }

    }

    public class AspNetUsers : IdentityUser
    {
        public virtual OrderModel OrderModel { get; set; }
    }
}

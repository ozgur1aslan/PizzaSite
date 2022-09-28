using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class DrinksOrderModel
    {

        [Key]
        public int Id { get; set; }

        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]

        public virtual AspNetUsers AspNetUsers { get; set; }


        public DateTime Date { get; set; }


        public string? DrinksModelDrinkName { get; set; }
        [ForeignKey("DrinksModelDrinkName")]

        public int DrinksModelFinalPrice { get; set; }
        [ForeignKey("DrinksModelFinalPrice")]
        public int DrinksModelId { get; set; }
        [ForeignKey("DrinksModelId")]
        public virtual DrinksModel DrinksModel { get; set; }


    }


}


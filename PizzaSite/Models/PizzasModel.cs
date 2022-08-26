using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaSite.Models
{
    public class PizzasModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image Title")]
        //[Range(1,100,ErrorMessage ="Range must be  between 1 and 100")]
        public string? ImageTitle { get; set; }
        public string? PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }
    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaSite.Models
{
    public class DrinksModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Image Title")]
        //[Range(1,100,ErrorMessage ="Range must be  between 1 and 100")]
        public string? ImageTitle { get; set; }
        public string? DrinkName { get; set; }
        public int FinalPrice { get; set; }
    }
}
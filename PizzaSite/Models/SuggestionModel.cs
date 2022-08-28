using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class SuggestionModel
    {
        [Key]
        public int Id { get; set; }

        public string? content { get; set; }


        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]

        public virtual AspNetUsers AspNetUsers { get; set; }

    }
}
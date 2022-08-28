using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class CounterModel
    {
        [Key]
        public int Id { get; set; }

        public string? complaint_count { get; set; }

        public string? suggestion_count { get; set; }

        public string? pizza_order_count { get; set; }
        public string? drink_order_count { get; set; }

    }
}
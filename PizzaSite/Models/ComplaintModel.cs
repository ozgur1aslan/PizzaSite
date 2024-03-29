﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaSite.Models
{
    public class ComplaintModel
    {
        [Key]
        public int Id { get; set; }

        public string? Content { get; set; }

        public DateTime Date { get; set; }

        public string AspNetUsersId { get; set; }
        [ForeignKey("AspNetUsersId")]

        public virtual AspNetUsers AspNetUsers { get; set; }

    }
}
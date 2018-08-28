using System;
using System.ComponentModel.DataAnnotations;

namespace mywebapp.api.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
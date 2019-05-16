using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DoAn1.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
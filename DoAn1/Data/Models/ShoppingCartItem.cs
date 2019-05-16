using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        
        public Product Product { get; set; }

        [Required]
        [StringLength(255)]
        public string ShoppingCartId { get; set; }
    }
}

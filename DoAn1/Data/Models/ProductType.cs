using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "không được để trống")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(255)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}

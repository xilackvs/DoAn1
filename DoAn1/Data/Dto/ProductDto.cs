using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Dto
{
    public class ProductDto
    {
        [Required(ErrorMessage = "không được để trống")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(255)]
        [Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mô tả ngắn")]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Mô tả chi tiết")]
        public string LongDescription { get; set; }

        [Required]
        [Range(0, 999.99)]
        [Display(Name = "Giá tiền")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Hình ảnh")]
        public string Photo { get; set; }

        public int ProductTypeID { get; set; }
    }
}

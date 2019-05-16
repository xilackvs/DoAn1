using DoAn1.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.ViewModels
{
    public class ProductViewModel
    {
        public int ProductViewModelId { get; set; }
        public Product Product { get; set; }
        public string Size { get; set; }
        public List<SelectListItem> Sizes { get; set; }

        public ProductViewModel()
        {
            Sizes = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "1",
                    Text = "XS"
                },
                new SelectListItem
                {
                    Value = "2",
                    Text = "S"
                },
                new SelectListItem
                {
                    Value = "3",
                    Text = "M"
                },
                new SelectListItem
                {
                    Value = "4",
                    Text = "L"
                },
                new SelectListItem
                {
                    Value = "5",
                    Text = "XL"
                },
                new SelectListItem
                {
                    Value = "6",
                    Text = "XXL"
                },
                new SelectListItem
                {
                    Value = "7",
                    Text = "XXXL"
                }
            };
        }
        ////public IList<Product> ListProduct { get; set; }
        ////[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //public int ProductViewModelId { get; set; }

        //[Required(ErrorMessage = "không được để trống")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[StringLength(255)]
        //[Display(Name = "Tên sản phẩm")]
        //public string ProductName { get; set; }

        //[Required]
        ////[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[StringLength(50)]
        //[Display(Name = "Mô tả ngắn")]
        //public string ShortDescription { get; set; }

        //[Required]
        //[StringLength(255)]
        //[Display(Name = "Mô tả chi tiết")]
        //public string LongDescription { get; set; }

        //[Required]
        //[Range(0, 999.99)]
        //[Display(Name = "Giá tiền")]
        //public double Price { get; set; }

        //[Required]
        //[Display(Name = "Hình ảnh")]
        //public string Photo { get; set; }

        //[Required]
        //[Display(Name = "Sản phẩm hot")]
        //public bool IsThisHot { get; set; }

        //public string Type { get; set; }


        ////Thời gian khởi tạo
        ////[Required]
        ////private DateTime _createdOn = DateTime.MinValue;
        ////[Display(Name = "Created On")]
        ////[DataType(DataType.DateTime)]
        ////[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        ////public DateTime CreateOn
        ////{
        ////    get
        ////    {
        ////        return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn;
        ////    }
        ////    set { _createdOn = value; }
        ////}

        ////Auto Id
        ////private static int nextId = 1;
        //public ProductViewModel()
        //{
        //    //this.Id = nextId;
        //    //nextId++;
        //    this.IsThisHot = false;
        //}
        //[Display(Name = "Loại sản phẩm")]
        //public int Id { get; set; }
        //public virtual ProductType ProductType { get; set; }

        //public List<SelectListItem> Types { get; set; }

        //public ProductViewModel(List<ProductType> productTypes)
        //{
        //    //this.Id = nextId;
        //    //nextId++;
        //    this.IsThisHot = false;
        //    Types = new List<SelectListItem>();
        //    foreach (var item in productTypes)
        //    {
        //        Types.Add(
        //            new SelectListItem { Value = item.Id.ToString(), Text = item.Name.ToString() }
        //            );
        //    }
        //}
    }
}

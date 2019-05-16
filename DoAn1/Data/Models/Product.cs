using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn1.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string LongDescription { get; set; }

        [Required]
        [Range(0, 999.99)]
        public double Price { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public bool IsThisHot { get; set; }
        #region
        //Thời gian khởi tạo
        //[Required]
        //private DateTime _createdOn = DateTime.MinValue;

        //[Display(Name = "Created On")]
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //public DateTime CreateOn
        //{
        //    get
        //    {
        //        return (_createdOn == DateTime.MinValue) ? DateTime.Now : _createdOn;
        //    }
        //    set { _createdOn = value; }
        //}

        //Auto Id
        //private static int nextId = 1;
        //public Product()
        //{
        //    this.Id = nextId;
        //    nextId++;
        //}
        #endregion
        public int ProductTypeID { get; set; }
        public virtual ProductType ProductType { get; set; }

        public Product()
        {
            this.IsThisHot = false;
        }
    }
}

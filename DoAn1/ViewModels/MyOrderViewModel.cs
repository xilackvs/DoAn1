using DoAn1.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.ViewModels
{
    public class MyOrderViewModel
    {
        public int Id { get; set; }
        public OrderDto OrderPlaceDetails { get; set; }
        public double OrderTotal { get; set; }
        public bool Status { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public IEnumerable<MyProductOrderInfo> ProductOrderInfos { get; set; }
    }

    public class MyProductOrderInfo
    {
        public string Size { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}


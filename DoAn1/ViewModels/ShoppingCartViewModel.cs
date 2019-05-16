using DoAn1.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IShoppingCartService ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
        public int ShoppingCartItemsTotal { get; set; }
    }
}

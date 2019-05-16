using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn1.Data.Interfaces;
using DoAn1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DoAn1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartService _shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, IShoppingCartService shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }

        public async Task<IActionResult> Index()
        {
            await _shoppingCart.GetShoppingCartItemsAsync();
            var shoppingCartCountTotal = await _shoppingCart.GetCartCountAndTotalAmmountAsync();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartItemsTotal = shoppingCartCountTotal.ItemCount,
                ShoppingCartTotal = shoppingCartCountTotal.TotalAmmount,
            };


            return View(shoppingCartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToShoppingCart(int productId, [FromForm]ProductViewModel productVM)
        {
            var selectedProduct = await _productRepository.GetProductByIdAsync(productId);
            if (selectedProduct == null)
            {
                return NotFound();
            }
            string productSize = "";
            if (productVM.Size == "1")
            {
                productSize = "XS";
            }
            if (productVM.Size == "2")
            {
                productSize = "S";
            }
            if (productVM.Size == "3")
            {
                productSize = "M";
            }
            if (productVM.Size == "4")
            {
                productSize = "L";
            }
            if (productVM.Size == "5")
            {
                productSize = "XL";
            }
            if (productVM.Size == "6")
            {
                productSize = "XXL";
            }
            if (productVM.Size == "7")
            {
                productSize = "XXXL";
            }

            await _shoppingCart.AddToCartAsync(selectedProduct, productSize);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = await _productRepository.GetProductByIdAsync(productId);
            if (selectedProduct == null)
            {
                return NotFound();
            }

            await _shoppingCart.RemoveFromCartAsync(selectedProduct, "");

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllCart()
        {
            await _shoppingCart.ClearCartAsync();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> SelectSize(int productId)
        //{
        //    var selectedProduct = await _productRepository.GetProductByIdAsync(productId);
        //    if (selectedProduct == null)
        //    {
        //        return NotFound();
        //    }
        //}
    }
}
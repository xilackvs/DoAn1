using DoAn1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Interfaces
{
    public interface IShoppingCartService
    {
        string Id { get; set; }
        IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }

        Task<int> AddToCartAsync(Product product,string size, int qty = 1);
        Task ClearCartAsync();
        Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItemsAsync();
        Task<int> RemoveFromCartAsync(Product product, string size);
        Task<(int ItemCount, double TotalAmmount)> GetCartCountAndTotalAmmountAsync();
    }
}

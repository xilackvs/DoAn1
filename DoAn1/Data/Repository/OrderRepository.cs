using DoAn1.Data.Dto;
using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using DoAn1.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MerchShopDbContext _merchShopDbContext;
        private readonly IShoppingCartService _shoppingCartService;

        public OrderRepository(MerchShopDbContext context, IShoppingCartService shoppingCartService)
        {
            _merchShopDbContext = context;
            _shoppingCartService = shoppingCartService;
        }

        public async Task DeliveryOrder(int id)
        {
            var waitingOrder = await _merchShopDbContext.Orders.FirstOrDefaultAsync(w => w.Id == id);
            waitingOrder.Status = true;

            await _merchShopDbContext.SaveChangesAsync();
        }

        public async Task CreateOrderAsync(Order order)
        {
            order.OrderPlacedTime = DateTime.Now;
            await _merchShopDbContext.Orders.AddAsync(order);

            var shoppingCartItems = await _shoppingCartService.GetShoppingCartItemsAsync();
            order.OrderTotal = (await _shoppingCartService.GetCartCountAndTotalAmmountAsync()).TotalAmmount;

            await _merchShopDbContext.OrderDetails.AddRangeAsync(shoppingCartItems.Select(e => new OrderDetail
            {
                Quantity = e.Quantity,
                Size = e.Size,
                ProductName = e.Product.ProductName,
                OrderId = order.Id,
                Price = e.Product.Price
            }));

            await _merchShopDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync()
        {
            return await _merchShopDbContext.Orders
                .Include(e => e.OrderDetails)
                .Select(e => new MyOrderViewModel
                {
                    Id = e.Id,
                    OrderPlacedTime = e.OrderPlacedTime,
                    OrderTotal = e.OrderTotal,
                    Status = e.Status,
                    OrderPlaceDetails = new OrderDto
                    {
                        AddressLine = e.AddressLine,
                        City = e.City,
                        Country = e.Country,
                        Email = e.Email,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        PhoneNumber = e.PhoneNumber,
                        State = e.State,
                        ZipCode = e.ZipCode
                    },
                    ProductOrderInfos = e.OrderDetails.Select(o => new MyProductOrderInfo
                    {
                        Size = o.Size,
                        Name = o.ProductName,
                        Price = o.Price,
                        Quantity = o.Quantity
                    })
                })
                .ToListAsync();

        }
        public async Task<IEnumerable<MyOrderViewModel>> GetAllOrdersAsync(string userId)
        {
            return await _merchShopDbContext.Orders
                .Where(e => e.UserId == userId)
                .Include(e => e.OrderDetails)
                .Select(e => new MyOrderViewModel
                {
                    OrderPlacedTime = e.OrderPlacedTime,
                    OrderTotal = e.OrderTotal,
                    Status = e.Status,
                    OrderPlaceDetails = new OrderDto
                    {
                        AddressLine = e.AddressLine,
                        City = e.City,
                        Country = e.Country,
                        Email = e.Email,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        PhoneNumber = e.PhoneNumber,
                        State = e.State,
                        ZipCode = e.ZipCode
                    },
                    ProductOrderInfos = e.OrderDetails.Select(o => new MyProductOrderInfo
                    {
                        Size = o.Size,
                        Name = o.ProductName,
                        Price = o.Price,
                        Quantity = o.Quantity
                    })
                })
                .ToListAsync();
        }
    }
}

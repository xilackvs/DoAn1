using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DoAn1.Data.Dto;
using DoAn1.Data.Interfaces;
using DoAn1.Data.Models;
using DoAn1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoAn1.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin, Seller")]
    public class OrderController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderController(
            IShoppingCartService shoppingCartService,
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _shoppingCartService = shoppingCartService;
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [AllowAnonymous]     
        public async Task<IActionResult> Checkout()
        {
            var cartItems = await _shoppingCartService.GetShoppingCartItemsAsync();
            if (cartItems?.Count() <= 0)
            {
                return Redirect("/shoppingcart");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous] 
        public async Task<IActionResult> Checkout([FromForm]OrderDto orderDto)
        {
            if (ModelState.IsValid)
            {
                var cartItems = await _shoppingCartService.GetShoppingCartItemsAsync();

                if (cartItems?.Count() <= 0)
                {
                    ModelState.AddModelError("", "Your Cart is empty. Please add some products before checkout");
                    return View(orderDto);
                }
                var order = _mapper.Map<OrderDto, Order>(orderDto);
                order.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await _orderRepository.CreateOrderAsync(order);
                await _shoppingCartService.ClearCartAsync();
                return View("CheckoutComplete");
            }
            else
                return View(orderDto);
        }

        [AllowAnonymous]
        public async Task<IActionResult> MyOrder()
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = await _orderRepository.GetAllOrdersAsync(userId);
            var listOrdersVM = new ListOrdersWithId
            {
                Orders = new List<OrderWithId>()
            };
            foreach (var item in orders)
            {
                var newOrder = new OrderWithId
                {
                    MyOrderViewModel = item,
                    Id = item.Id
                };
                listOrdersVM.Orders.Add(newOrder);
            }
            return View(listOrdersVM);
        }

        [HttpGet]
        public async Task<IActionResult> AllOrders()
        {
            ViewBag.ActionTitle = "All Orders";
            var orders = await _orderRepository.GetAllOrdersAsync();
            var listOrdersVM = new ListOrdersWithId
            {
                Orders = new List<OrderWithId>()
            };
            foreach (var item in orders)
            {
                var newOrder = new OrderWithId
                {
                    MyOrderViewModel = item,
                    Id = item.Id
                };
                listOrdersVM.Orders.Add(newOrder);
            }
            return View(listOrdersVM);
        }

        [HttpPost]
        public async Task<IActionResult> CheckOrder(int orderId)
        {
            await _orderRepository.DeliveryOrder(orderId);
            return RedirectToAction("AllOrders", "Order");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Kanoo.Models;
using Kanoo.Services;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Kanoo.Controllers
{
    public class OrdersController : Controller
    {
        private readonly CartService _cartService;
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Authorize()]
        public async Task<IActionResult> Checkout()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var cart = _cartService.GetCart();

            if (cart == null) {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(o => o.Id == cart.OrderId);

            order ??= new Order {
                UserId = userId
            };

            var orderItems = new List<OrderItem>();

            foreach(var cartItem in cart.CartItems)
            {
                var orderItem = new OrderItem {
                    OrderId = order.Id,
                    Service = cartItem.ProductType.ToString(),
                    Quantity = cartItem.Quantity,
                    Price = order.Total
                };

                orderItems.Add(orderItem);
            }

            order.OrderItems = orderItems;

            foreach (var item in order.OrderItems)
            {
                switch (item.Service)
                {
                    case "Flight":
                        order.Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.Flight.Price)); 
                        break;

                    case "Car":
                        order.Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.Car.PricePerDay)); 
                        break;

                    case "Stay":
                        order.Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.Stay.PricePerDay)); 
                        break;

                    // case "FlightAndStay":
                    //     order.Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.FlightAndStay.P)); 
                    //     break;
                }
            }
            // order.Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.Car.PricePerDay)); 

            return View("Details", order);
        }
    }
}
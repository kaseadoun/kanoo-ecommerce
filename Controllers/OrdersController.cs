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

            if (cart == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(o => o.Id == cart.OrderId);

            order ??= new Order
            {
                UserId = userId
            };

            var orderItems = new List<OrderItem>();

            foreach (var cartItem in cart.CartItems)
            {
                var orderItem = new OrderItem
                {
                    OrderId = order.Id,
                    Service = cartItem.ProductType.ToString(),
                    Quantity = cartItem.Quantity,
                };

                orderItems.Add(orderItem);

                switch (cartItem.ProductType)
                {
                    case ProductType.Flight:
                        orderItem.Price = cartItem.Quantity * cartItem.Flight.Price;
                        break;

                    case ProductType.Car:
                        orderItem.Price = cartItem.Quantity * cartItem.Car.PricePerDay;
                        break;

                    case ProductType.Stay:
                        orderItem.Price = cartItem.Quantity * cartItem.Stay.PricePerDay;
                        break;

                    case ProductType.FlightAndStay:
                        orderItem.Price = cartItem.Quantity * cartItem.FlightAndStay.Price;

                        // Include the DiscountDepartment to fetch the discount
                        var flightAndStay = await _context.FlightAndStays
                            .Include(fas => fas.DiscountDepartment)
                            .FirstOrDefaultAsync(fas => fas.Id == cartItem.FlightAndStay.Id);

                        if (flightAndStay?.DiscountDepartment != null)
                        {
                            double discountAmount = (double)orderItem.Price * flightAndStay.DiscountDepartment.DiscountAmount;
                            orderItem.Price -= (decimal)discountAmount;
                        }
                        break;
                }
                order.Total += orderItem.Price;
            }

            order.OrderItems = orderItems;

            return View("Details", order);
        }
    }
}
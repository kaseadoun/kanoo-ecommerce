using Microsoft.AspNetCore.Mvc;
using Kanoo.Models;
using Kanoo.Services;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;

namespace Kanoo.Controllers
{
    public class OrdersController : Controller
    {
        private readonly CartService _cartService;
        private readonly ApplicationDbContext _context;

        private readonly IConfiguration _configuration;

        public OrdersController(CartService cartService, ApplicationDbContext context, IConfiguration configuration)
        {
            _cartService = cartService;
            _context = context;
            _configuration = configuration;
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

        [Authorize()]
        [HttpPost]
        public IActionResult ProcessPayment()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var cart = _cartService.GetCart();

            if (cart == null) return NotFound();

            decimal total = 0;
            var test = cart.CartItems.Sum(cartItem =>
                {
                    switch (cartItem.ProductType)
                    {
                        case ProductType.Flight:
                            total += cartItem.Quantity * cartItem.Flight.Price;
                            break;

                        case ProductType.Car:
                            total += cartItem.Quantity * cartItem.Car.PricePerDay;
                            break;

                        case ProductType.Stay:
                            total += cartItem.Quantity * cartItem.Stay.PricePerDay;
                            break;

                        case ProductType.FlightAndStay:
                            total += cartItem.Quantity * cartItem.FlightAndStay.Price;
                            break;
                    };
                    return total;
                });

            var order = new Order
            {
                UserId = userId,
                Total = total,
                OrderItems = new List<OrderItem>()
            };

            // Set Stripe API key
            // Stripe must be configured before you send it off
            StripeConfiguration.ApiKey = _configuration.GetSection("Stripe")["SecretKey"];

            // Create a session and transmit that session to Stripe
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)order.Total,
                        Currency = "cad",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "WorldDominion Purchase",
                        },
                    },
                    Quantity = 1,
                  },
                },
                PaymentMethodTypes = new List<string>
                {
                    // Card is generic. You can take anything. Debit, credit, etc
                    // You can configure what the payment form looks like, ie. what you accept
                    "card"
                },
                Mode = "payment",
                SuccessUrl = "https://" + Request.Host + "/Orders/SaveOrder",
                CancelUrl = "https://" + Request.Host + "/Carts/ViewMyCart",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            // Raw way of doing a redirect
            Response.Headers.Add("Location", session.Url); // return to Stripe
            return new StatusCodeResult(303);
        }

        [Authorize()]
        public async Task<IActionResult> SaveOrder()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var cart = _cartService.GetCart();

            if (userId == null || cart == null) return NotFound();

            var order = new Order
            {
                UserId = userId,
                Total = cart.CartItems.Sum(cartItem => (decimal)(cartItem.Quantity * cartItem.Product.MSRP)),
                OrderItems = new List<OrderItem>(),
                PaymentReceived = true
            };

            // foreach (var cartItem in cart.CartItems)
            // {
            //     order.OrderItems.Add(new OrderItem
            //     {
            //         OrderId = order.Id,
            //         ProductName = cartItem.Product.Name,
            //         Quantity = cartItem.Quantity,
            //         Price = cartItem.Product.MSRP
            //     });
            // }
            foreach (var cartItem in cart.CartItems)
            {
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

                order.OrderItems.Add(new OrderItem
                {
                    OrderId = order.Id,
                    Service = cartItem.ProductType.ToString(),
                    Quantity = cartItem.Quantity,
                    Price = orderItem.Price;
                });

            await _context.AddAsync(order);
            await _context.SaveChangesAsync();

            _cartService.DestroyCart();

            // Show user the new order they just made
            return RedirectToAction("Details", new { id = order.Id });
        }
    }
}
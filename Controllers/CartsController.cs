using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace Kanoo.Controllers
{
    public class CartsController : Controller
    {
        private readonly string _cartSessionKey;
        private readonly ApplicationDbContext _context;
        public CartsController(ApplicationDbContext context)
        {
            _cartSessionKey = "Cart";
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cart = GetCart();

            if (cart == null)
            {
                return NotFound();
            }

            if (cart.CartItems.Count > 0)
            {
                foreach (var cartItem in cart.CartItems)
                {
                    var flight = await _context.Flights
                    .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (flight != null)
                    {
                        cartItem.Flight = flight;
                    }

                    var car = await _context.Cars
                    .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (car != null)
                    {
                        cartItem.Car = car;
                    }

                    var stays = await _context.Stays
                   .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (stays != null)
                    {
                        cartItem.Stay = stays;
                    }

                    var flightAndHotel = await _context.FlightAndStays
                   .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (flightAndHotel != null)
                    {
                        cartItem.FlightAndStay = flightAndHotel;
                    }
                }
            }

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity, ProductType productType)
        {
            var cart = GetCart();

            if (cart == null)
            {
                return NotFound();
            }

            var cartItem = cart.CartItems.Find(ci => ci.ProductId == productId && ci.ProductType == productType);

            // Add Flight
            if (cartItem != null && cartItem.Flight != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                switch (productType)
                {
                    case ProductType.Flight:
                        var flight = await _context.Flights.FirstOrDefaultAsync(p => p.Id == productId);
                        if (flight == null) return NotFound();
                        cartItem = new CartItem { ProductId = productId, Quantity = quantity, Flight = flight, ProductType = ProductType.Flight };
                        break;

                    case ProductType.Car:
                        var car = await _context.Cars.FirstOrDefaultAsync(p => p.Id == productId);
                        if (car == null) return NotFound();
                        cartItem = new CartItem { ProductId = productId, Quantity = quantity, Car = car, ProductType = ProductType.Car };
                        break;

                    case ProductType.Stay:
                        var stay = await _context.Stays.FirstOrDefaultAsync(p => p.Id == productId);
                        if (stay == null) return NotFound();
                        cartItem = new CartItem { ProductId = productId, Quantity = quantity, Stay = stay, ProductType = ProductType.Stay };
                        break;

                    case ProductType.FlightAndStay:
                        var flightAndStay = await _context.FlightAndStays.FirstOrDefaultAsync(p => p.Id == productId);
                        if (flightAndStay == null) return NotFound();
                        cartItem = new CartItem { ProductId = productId, Quantity = quantity, FlightAndStay = flightAndStay, ProductType = ProductType.FlightAndStay };
                        break;

                    default:
                        return BadRequest("Invalid product type.");
                }
                cart.CartItems.Add(cartItem);
            }


            SaveCart(cart);

            return RedirectToAction("Index");
        }

        private Cart? GetCart()
        {
            var cartJson = HttpContext.Session.GetString(_cartSessionKey);

            return cartJson == null ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);
        }

        private void SaveCart(Cart cart)
        {
            var cartJson = JsonConvert.SerializeObject(cart);

            HttpContext.Session.SetString(_cartSessionKey, cartJson);
        }
    }
}
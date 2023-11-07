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

            // again, we need to change product to the equivalent to our project
            if (cart.CartItems.Count > 0)
            {
                foreach (var cartItem in cart.CartItems)
                {
                    var flight = await _context.Flights
                    .Include(product => product.Department)
                    .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (flight != null)
                    {
                        cartItem.Flight = flight;
                    }

                    var car = await _context.Cars
                    .Include(product => product.Department)
                    .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (car != null)
                    {
                        cartItem.Car = car;
                    }

                    var stays = await _context.Stays
                   .Include(product => product.Department)
                   .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (stays != null)
                    {
                        cartItem.Stay = stays;
                    }

                    var flightAndHotel = await _context.FlightAndHotels
                   .Include(product => product.Department)
                   .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (flightAndHotel != null)
                    {
                        cartItem.FlightAndHotel = flightAndHotel;
                    }
                }
            }

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity)
        {
            var cart = GetCart();

            if (cart == null)
            {
                return NotFound();
            }

            var cartItem = cart.CartItems.Find(cartItem => cartItem.ProductId == productId);

            // Add Flight
            if (cartItem != null && cartItem.Flight != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                var product = await _context.Flights
                    .FirstOrDefaultAsync(p => p.Id == productId);

                if (product == null)
                {
                    return NotFound();
                }

                cartItem = new CartItem { ProductId = productId, Quantity = quantity, Flight = product };
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
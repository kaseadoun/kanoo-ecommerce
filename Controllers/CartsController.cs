using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kanoo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
                    var product = await _context.Products
                    .Include(product => product.Department)
                    .FirstOrDefaultAsync(product => product.Id == cartItem.ProductId);

                    if (product != null)
                    {
                        cartItem.Product = product;
                    }
                }
            }

            return View();
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
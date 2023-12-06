using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public int? OrderId { get; set; } = 0;
    }
}
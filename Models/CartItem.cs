using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        // Change the Product to our respective items.
        public Flight Flight { get; set; } = new Flight();
        public Stay Stay { get; set; } = new Stay();
        public Car Car { get; set; } = new Car();
        public FlightAndHotel FlightAndHotel { get; set; } = new FlightAndHotel();

    }
}
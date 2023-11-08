using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public enum ProductType
    {
        Flight,
        Car,
        Stay,
        FlightAndStay
    }
    public class CartItem
    {
        public ProductType ProductType { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        // Change the Product to our respective items.
        public Flight? Flight { get; set; }
        public Stay? Stay { get; set; }
        public Car? Car { get; set; }
        public FlightAndStay? FlightAndStay { get; set; }

    }
}
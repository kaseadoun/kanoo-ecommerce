using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models {
    public class TravelService {
        
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = String.Empty;

        [Required, StringLength(1000)]
        public string Description { get; set; } = String.Empty;

        // Relationship with Products and place to store products in the Department instance
        public virtual ICollection<Flight>? Flight { get; set; } = new List<Flight>();
        
    }
}
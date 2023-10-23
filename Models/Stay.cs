using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models {
    public class Stay {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Surrounding Airport")]
        public Airport Destination { get; set; } = Airport.YYZ;

        [Required]
        public DateTime Arrive { get; set; } = DateTime.Now;

        [Required]
        public DateTime Depart { get; set; } = DateTime.Now;

        [Required]
        public int Rooms { get; set; } = 1;

        [Required]

        public int Adults { get; set; } = 2;

        [Required]
        public int Children { get; set; } = 0;
    }
}
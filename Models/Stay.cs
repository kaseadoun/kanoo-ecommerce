using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class Stay
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Destination")]
        public AirportCodes DestinationName { get; set; } = AirportCodes.YYZ;

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required]
        public int Rooms { get; set; } = 1;

        [Required]

        public int Adults { get; set; } = 2;

        [Required]
        public int Children { get; set; } = 0;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal PricePerDay { get; set; } = 0.01M;

        public virtual ICollection<FlightAndStay>? FlightAndStays { get; set; } = new List<FlightAndStay>();
    }
}
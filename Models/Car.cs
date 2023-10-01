using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models {
    public class Car {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Travel Service")]
        public int TravelServiceId { get; set; } = 0;

        [Required]
        [Display(Name = "Car Drop Off")]
        public Airport Destination { get; set; } = Airport.YYZ;

        [Required]
        public DateTime From { get; set; } = DateTime.Now;

        [Required]
        public DateTime To { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 4)]
        [Display(Name = "Number of Drivers")]

        public int NumOfDrivers { get; set; } = 1;


        [ForeignKey("TravelServiceId")]
        // Creates the association to departments 
        // Allows a department to be stored in an instance of a product
        public virtual TravelService? Department { get; set; }
    }
}
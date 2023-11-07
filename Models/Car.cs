using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NuGet.Protocol.Plugins;

namespace Kanoo.Models {
    public class Car {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Destination")]
        public string DestinationName { get; set; } = "YYZ";

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required, StringLength(100)]
        public string TypeOfCar { get; set; } = String.Empty;

        [Required]
        [Range(1, 4)]
        [Display(Name = "Number of Drivers")]
        public int NumOfDrivers { get; set; } = 1;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal PricePerDay { get; set; } = 0.01M;
    }
}
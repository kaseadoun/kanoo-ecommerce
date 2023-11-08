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
        public string DestinationName { get; set; } = "Toronto";

        [Required]
        [Display(Name = "Region ID")]
        public int RegionId { get; set; } = 0;

        [Required]
        [Display(Name = "Company")]
        public string CompanyName { get; set; } = "Default";

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required, StringLength(100)]
        [Display(Name = "Type of Car")]
        public string TypeOfCar { get; set; } = "Default";

        [Required]
        [Range(1, 4)]
        [Display(Name = "Number of Drivers")]
        public int NumOfDrivers { get; set; } = 1;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal PricePerDay { get; set; } = 50.00M;

        [ForeignKey("RegionId")]
        public virtual Destination? Region { get; set; }
    }
}
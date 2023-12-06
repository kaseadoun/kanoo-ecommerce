using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models {

    public enum ServiceClass
    {
        ECONOMY,
        PREMIUM_ECONOMY,
        BUSINESS,
        FIRST
    }

    public class Flight {

        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Arrival Airport Id")]
        public int ArrivalAirportId { get; set; } = 0;

        [Required]
        [Display(Name = "Departure Airport Id")]
        public int DepartureAirportId { get; set; } = 0;

        [Required]
        public string From { get; set; } = "YYZ";

        [Required]
        public string To { get; set; } = "DFW";

        [Required]
        public DateTime Departure { get; set; } = DateTime.Now.Date;
        
        [Required]
        public DateTime Arrival { get; set; } = DateTime.Now.Date;

        [Required]
        public int NumOfAdults { get; set; } = 1;

        [Required]
        public int NumOfSeniors { get; set; } = 0;

        [Required]
        public ServiceClass ServiceClass { get; set; } = ServiceClass.ECONOMY;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal Price { get; set; } = 0.01M;

        [ForeignKey("ArrivalAirportId")]
        public virtual Airport? ArrivalAirport { get; set; }
        
        
        [ForeignKey("DepartureAirportId")]
        public virtual Airport? DepartureAirport { get; set; }

        public virtual ICollection<FlightAndStay>? FlightAndStays { get; set; } = new List<FlightAndStay>();
    }

}
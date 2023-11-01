using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models {

    public enum AirportCodes {
        ATL,    // Atlanta Hartsfield-jackson Intl Apt
        DXB,    // Dubai International
        HND,    // Tokyo Intl (Haneda)
        LHR,    // London Heathrow Apt
        IST,    // Istanbul Airport
        DEN,    // Denver Intl Apt
        DFW,    // Dallas Dallas/Fort Worth Intl Apt
        CAN,    // Guangzhou (CN)
        ORD,    // Chicago O'Hare International Apt
        LAX,    // Los Angeles International Airport
        YYZ,    // Toronto Pearson International Airport
        YYC,    // Calgary International Airport
        YUL,    // Montreal-Pierre Elliott Trudeau International Airport
        YWH     // Victoria Harbour Airport
    }

    public class Flight {

        [Key]
        public int Id { get; set; } = 0;

        [Required]
        public AirportCodes From { get; set; } = AirportCodes.YYZ;

        [Required]
        public AirportCodes To { get; set; } = AirportCodes.DFW;

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal Price { get; set; } = 0.01M;

        public virtual ICollection<FlightAndStay>? FlightAndStays { get; set; } = new List<FlightAndStay>();
    }

}
using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models {

    public enum Airport {
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
        [Display(Name = "Travel Service")]
        public int TravelServiceId { get; set; } = 0;

        [Required]
        public Airport From { get; set; } = Airport.YYZ;

        [Required]
        public Airport To { get; set; } = Airport.DFW;

        [Required]
        public DateTime Leave { get; set; } = DateTime.Now;

        [Required]
        public DateTime Return { get; set; } = DateTime.Now;


        [ForeignKey("TravelServiceId")]
        // Creates the association to departments 
        // Allows a department to be stored in an instance of a product
        public virtual TravelService? Department { get; set; }
    }

}
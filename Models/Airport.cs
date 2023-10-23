using System.ComponentModel.DataAnnotations;

namespace Kanoo.Models
{
    public class Airport
    {
        // https://rapidapi.com/aviolog-aviolog-default/api/akrx

        [Key]
        public int AirportId { get; set; }
        [Required]
        [Display(Name = "Airport Name")]
        public string AirportName { get; set; }
        [Required]
        [Display(Name = "Airport Code")]
        public string AirportIata { get; set; }
        public string City { get; set; }
        public string Continent { get; set; }
        [Display(Name = "Country")]
        public string IsoCountry { get; set; }
    }
}
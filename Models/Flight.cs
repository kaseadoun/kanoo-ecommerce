using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models {
    public class Flight {

        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Travel Service")]
        public int TravelServiceId { get; set; } = 0;

        [Required]
        public string From { get; set; } = "YYZ";

        [Required]
        public string To { get; set; } = "DFW";

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
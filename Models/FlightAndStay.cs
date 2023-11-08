using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class FlightAndStay
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Flight")]
        public int FlightId { get; set; } = 0;

        [Required]
        [Display(Name = "Stay")]
        public int StayId { get; set; } = 0;

        [Required]
        [Display(Name = "Discount")]
        public int DiscountId { get; set; } = 0;

        [Required]
        public AirportCodes From { get; set; } = AirportCodes.YYZ;

        [Required]
        public AirportCodes To { get; set; } = AirportCodes.LAX;

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [ForeignKey("FlightId")]
        public virtual Flight? FlightDepartment { get; set; }

        [ForeignKey("StayId")]
        public virtual Stay? StayDepartment { get; set; }

        [ForeignKey("DiscountId")]
        public virtual Discount? DiscountDepartment { get; set; }
    }
}
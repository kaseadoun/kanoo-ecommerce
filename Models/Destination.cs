using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanoo.Models
{
    public class Destination
    {
        [Key]
        public int Key { get; set; } = 0;

        [Required]
        public string RegionId { get; set; } = "0";

        [Required, StringLength(100)]
        public string City { get; set; } = "Toronto";

        [Required, StringLength(80)]
        public string Country { get; set; } = "Canada";

        [Required]
        public double Latitude { get; set; } = 43.6532;

        [Required]
        public double Longitude { get; set; } = -79.3832;
    }
}
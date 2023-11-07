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
    public class Airport
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required, StringLength(5)]
        public string IataCode { get; set; }

        [Required, StringLength(250)]
        public string AirportName { get; set; }
    }
}
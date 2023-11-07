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

        [Required, StringLength(100)]
        public string City { get; set; }

        [Required, StringLength(100)]
        public string Region { get; set; }

        [Required, StringLength(80)]
        public string Country { get; set; }
    }
}
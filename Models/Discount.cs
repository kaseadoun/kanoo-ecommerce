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
    public class Discount
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        public string Description { get; set; }

        [Required]
        public double DiscountAmount { get; set; }
    }
}
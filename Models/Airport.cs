using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Kanoo.Models
{
    // https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
    // https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
    public class Airport
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required, StringLength(5)]
        public string IataCode { get; set; } = String.Empty;

        [Required, StringLength(250)]
        public string AirportName { get; set; } = String.Empty;

        [Required, StringLength(250)]
        public string DestinationName { get; set; } = String.Empty;
    }
}
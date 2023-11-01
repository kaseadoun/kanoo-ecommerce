using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanoo.Models
{
    public class SidebarItem
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
    }
}
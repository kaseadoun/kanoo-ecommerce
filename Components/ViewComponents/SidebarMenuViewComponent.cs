using Kanoo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanoo.Components.ViewComponents
{
    public class SidebarMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var list = new List<SidebarItem> {
                new SidebarItem { Controller = "Flights", Action = "Index", Label = "Flights", Icon = "bi-airplane fs-1"},
                new SidebarItem { Controller = "Cars", Action = "Index", Label = "Cars", Icon = "bi-car-front-fill fs-1"},
                new SidebarItem { Controller = "Stays", Action = "Index", Label = "Stays", Icon = "bi-house fs-1"},
                new SidebarItem { Controller = "FlightAndHotels", Action = "Index", Label = "Flights and Hotels", Icon = "bi-luggage-fill fs-1"},
                new SidebarItem { Controller = "Airports", Action = "Index", Label = "Airports", Icon = "bi-luggage-fill fs-1"},
                new SidebarItem { Controller = "TravelAdvisors", Action = "Index", Label = "API (test/debugging)", Icon = "bi-luggage-fill fs-1"}
            };
            return View(list);
        }
    }
}
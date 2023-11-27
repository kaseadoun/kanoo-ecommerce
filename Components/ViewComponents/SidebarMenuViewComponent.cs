using Kanoo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanoo.Components.ViewComponents
{
    public class SidebarMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var list = new List<SidebarItem>();

            if (User.IsInRole("Admin"))
            {
                list = new List<SidebarItem> {
                new SidebarItem { Controller = "Airports", Action = "Index", Label = "(Admin) Airports", Icon = "bi-luggage-fill fs-1"},
                new SidebarItem { Controller = "Destinations", Action = "Index", Label = "(Admin) Destinations", Icon = "bi-luggage-fill fs-1"},
                new SidebarItem { Controller = "Flights", Action = "Index", Label = "Flights", Icon = "bi-airplane fs-1"},
                new SidebarItem { Controller = "Cars", Action = "Index", Label = "Cars", Icon = "bi-car-front-fill fs-1"},
                new SidebarItem { Controller = "Stays", Action = "Index", Label = "Stays", Icon = "bi-house fs-1"},
                new SidebarItem { Controller = "FlightAndStays", Action = "Index", Label = "Flights and Stays", Icon = "bi-luggage-fill fs-1"}
                };
            } 
            else {
                list = new List<SidebarItem> {
                new SidebarItem { Controller = "Flights", Action = "Index", Label = "Flights", Icon = "bi-airplane fs-1"},
                new SidebarItem { Controller = "Cars", Action = "Index", Label = "Cars", Icon = "bi-car-front-fill fs-1"},
                new SidebarItem { Controller = "Stays", Action = "Index", Label = "Stays", Icon = "bi-house fs-1"},
                new SidebarItem { Controller = "FlightAndStays", Action = "Index", Label = "Flights and Stays", Icon = "bi-luggage-fill fs-1"}
                };
            }

            return View(list);
        }
    }
}
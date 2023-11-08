using Microsoft.AspNetCore.Mvc;
using Kanoo.Models;

namespace Kanoo.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<MenuItem>
        {
            new MenuItem { Controller = "Home", Action = "Index", Label = "Home"},
            new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy"},
            new MenuItem { Controller = "Home", Action = "Brief", Label = "Brief"},
            new MenuItem { Controller = "Carts", Action = "Index", Label = "View My Cart" }
        };

            return View(menuItems);
        }
    }
}
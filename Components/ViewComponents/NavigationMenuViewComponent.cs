using Kanoo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanoo.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var list = new List<MenuItem> {
                new MenuItem { Controller = "Home", Action = "Index", Label = "Home"},
                new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy"},
                new MenuItem { Controller = "Home", Action = "Brief", Label = "Brief"}
            };
            return View(list);
        }
    }
}
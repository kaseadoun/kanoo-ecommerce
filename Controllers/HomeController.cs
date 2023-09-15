using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kanoo.Models;

namespace Kanoo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Brief()
    {
        List<Dictionary<string, string>> briefInfo = new List<Dictionary<string, string>>
        {
            // Dictionary for company info
            new Dictionary<string, string> {
                {"Company Name", "Kanoo"},
                {"Company Description", "Kanoo has a focus of providing a relaxing way of setting up vacations by providing packages and planning services."},
                {"Group Members and Roles", "Karsten Leung - Full Stack Developer<br/>Emily Rose - Full Stack Developer<br/>John Gu - Full Stack Developer"}
            },
            // Dictionary for proposal
            new Dictionary<string, string> {
                {"Description of the Site", "Kanoo is an eCommerce business that provides vacation packages and planning services."},
                {"The Products or Services", "Vacation packages and planning services."},
                {"Industry Needs to be Fulfilled", "Travel and planning needs."},
                {"Roles User Need to Fill", "Customer role."}
            }
        };

        return View(briefInfo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

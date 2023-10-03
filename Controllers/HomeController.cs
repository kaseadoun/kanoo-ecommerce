﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kanoo.Models;
using Microsoft.CodeAnalysis.Text;

namespace Kanoo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailSender emailSender;

    public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
    {
        _logger = logger;
        this.emailSender = emailSender;
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
                {"Company Description", "Kanoo has a focus of providing a relaxing way of setting up vacations by providing packages and planning services.<br/>Kanoo makes creating your next dream trip easy, quick, and hassle free! We aim to help you design your itinerary with the combination of beautiful destinations, amazing attractions and of course, cozy stays!<br/>Whether you are an experienced trip planner, or the \"click and go\" person, you will find everything with ease here!"},
                {"Group Members and Roles", "Karsten Leung - Full Stack Developer<br/>Emily Rose - Full Stack Developer<br/>John Gu - Full Stack Developer"}
            },
            // Dictionary for proposal
            new Dictionary<string, string> {
                {"Description of the Site", "Kanoo is an eCommerce website that provides vacation design and planning packages."},
                {"The Products or Services", "Kanoo provides different combinations of destinations, attractions and stay with modification ability for customers."},
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

    // Send email based on the contents of the help chat form 
    [HttpPost]
    [Route("send")]
    public async Task<IActionResult> Send(string email, string name, string message)
    {
        await emailSender.SendEmailAsync(email, name, message);
        return View("Index");
    }
}

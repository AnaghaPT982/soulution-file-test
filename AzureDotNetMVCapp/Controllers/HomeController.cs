using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AzureDotNetMVCapp.Models;
using AzureDotNetMVCapp.Data;

namespace AzureDotNetMVCapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private azureappdbcontext _context;


    public HomeController(ILogger<HomeController> logger, azureappdbcontext context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        var sunscreen = _context.Sunscreens.ToList();
        ViewBag.Sunscreen = sunscreen;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

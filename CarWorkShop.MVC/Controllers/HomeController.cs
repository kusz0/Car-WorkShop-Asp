using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkShop.MVC.Models;

namespace CarWorkShop.MVC.Controllers;

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
        var model = new List<Person>()
        {
            new Person()
            {
                FirstName = "Kacper",
                LastName = "Kuszek"
            },
            new Person()
            {
                FirstName = "Iza",
                LastName = "Sadowska"
            }
        };
        return View(model);
    }
    public IActionResult About()
    {
        var model = new AboutModel()
        {
            Title = "CarWorkShop application",
            Description = "Get your car fixed fast with trusted mechanics nearby",
            Tags = new List<string>
            {
                "CarRepair", "AutoService","VehicleMaintenance","GarageApp","CarCare"
            }
            
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

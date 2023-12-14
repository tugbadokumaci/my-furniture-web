using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using furniture_ecommerce.Models;

namespace furniture_ecommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // oluşturulan method türleri IActionResult türünden yani interface
        // methodların bağlı olduğu view vardır

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

    public IActionResult Test()
    {
        return View();
    }
}

/*
 * nuradaki methodların bağlı olduğu view(home, shared) vardır.
 * home: controller bağlı olduğu action tutultuüu türetildiği
 * shared: sayfa değişse de asahip kalan alanldardır. shared. LAYOUT
 * 
 */

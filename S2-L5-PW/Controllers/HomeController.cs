using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S2_L5_PW.Models;

namespace S2_L5_PW.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var products = ProductRepository.GetAllProducts();
        return View(products);
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
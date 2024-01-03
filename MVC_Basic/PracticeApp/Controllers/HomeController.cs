using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeApp.Models;


namespace PracticeApp.Controllers;

using DAL;
using BOL;

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

      public IActionResult Users()
    {
        return View();
    }

      public IActionResult Welcome()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Users(string uname,string password)
    {   

        List<User>ulist=new List<User>();
        if(uname=="tushar"&&password=="pass@123")
        {
            return this.RedirectToAction("Welcome");
        }
        // else{
        //    return this.RedirectToAction("Register");
        // }
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

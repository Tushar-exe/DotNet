using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeApp.Models;


namespace PracticeApp.Controllers;

using DAL;
using BOL;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

     public IActionResult Register()
    {   
        
        return View();
    }
 
   

    

    [HttpPost]
    public IActionResult Register(string uname,string password,string emailId)
    {   
        User u1=new User(uname,password,emailId);

        DBManager.Register(u1);

        Console.WriteLine(u1.emailId);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

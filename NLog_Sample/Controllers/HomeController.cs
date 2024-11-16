using Microsoft.AspNetCore.Mvc;
using NLog;
using NLog_Sample.Models;
using System.Diagnostics;

namespace NLog_Sample.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static readonly Logger nlog = LogManager.GetCurrentClassLogger();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        _logger.LogInformation("This Log Save In Database SQLServer");


        //Person person = new Person()
        //{
        //    Name = "MohamadMahdi",
        //    LastName = "Tavakoli",
        //    PhoneNumber = "09100000000",
        //};
        ////add To DataBase
        ////Save

        //_logger.LogInformation("New Prsern {Person}", person);



        //_logger.LogTrace("this is a LogTrace log");
        //_logger.LogDebug("this is a LogDebug log");
        //_logger.LogInformation("this is a LogInformation log");
        //_logger.LogWarning("this is a LogWarning log");
        //_logger.LogError("this is a LogError log");
        //_logger.LogCritical("this is a LogCritical log");

        //Sum(5, 6);

        //for (int i = 0; i < 250000; i++)
        //{
        //    _logger.LogInformation($"Test Log {i}");
        //}

        return View();
    }




    private int Sum(int a, int b)
    {
        try
        {
            nlog.Trace("Enter Sum");
            nlog.Debug($"a = {a} and b = {b}");

            int c = a + b;
            nlog.Debug($"c = a + b ==> {c}");

            nlog.Info("sum method run");

            return c;
        }
        catch (Exception ex)
        {
            nlog.Error("error", ex);

            throw;
        }

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
public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public override string ToString()
    {
        return $"{Name} {LastName}";
    }

}
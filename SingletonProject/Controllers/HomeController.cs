using Microsoft.AspNetCore.Mvc;
using SingletonProject.Models;
using System.Diagnostics;
using SingletonProject.Infrastructure;
namespace SingletonProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var cnt = ViewCounter.GetInstance();

            cnt.AddCount();


            return View(cnt.Count);

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
}
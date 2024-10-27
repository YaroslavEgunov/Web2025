using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web2025_1.Models;

namespace Web2025_1.Controllers
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
            return View();

        }       
        
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult NameInspections()
        {
            return View();
        }

        public IActionResult Math()
        {
            return View();
        }

        public IActionResult Table()
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

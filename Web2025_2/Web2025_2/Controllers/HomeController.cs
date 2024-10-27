using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Web2025_2.Models;

namespace Web2025_2.Controllers
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

		public IActionResult Task1()
		{
			return View();
		}

		public IActionResult Task2()
		{
			return View();
		}

		public IActionResult Task3()
		{
			return View();
		}

		public IActionResult Task4()
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

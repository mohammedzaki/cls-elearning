using ConnectToDB.Data;
using ConnectToDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConnectToDB.Controllers
{
    public class HomeController : Controller
	{
		ApplicationDbContext _dbContext;

		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
			_dbContext = context;
		}

        public IActionResult Index()
        {
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
}
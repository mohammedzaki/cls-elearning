using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Areas.Admin.Contollers
{
	[Area("Admin")]
	public class HomeController : Controller
    {
		public IActionResult Index()
        {
            return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace ELearningAppReview.Contollers
{
	public class BooksController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

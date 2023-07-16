using ELearningApp.Config;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Areas.Admin.Contollers
{
	[Area("Admin")]
	[Authorize]
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
			/*var username = HttpContext.Session.GetString(SessionKeys.SessionUserNameKey);

            var userid = HttpContext.Session.GetString(SessionKeys.SessionUserIdKey);

			ViewBag.username = username;
			ViewBag.userid = userid;

			if (string.IsNullOrEmpty(username))
				return Redirect("/Admin/Login");
*/
            return View();
		}
	}
}

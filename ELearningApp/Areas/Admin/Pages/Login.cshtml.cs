using ELearningApp.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ELearningApp.Areas.Admin.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public InputData Input { get; set; }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                HttpContext.Session.SetString(SessionKeys.SessionUserNameKey, Input.Username);
                HttpContext.Session.SetString(SessionKeys.SessionUserIdKey, "123");
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }


        public class InputData 
        {
            [Required]
            public string Username { get; set; }

            [Required]
            public string Password { get; set; }
        }
    }
}

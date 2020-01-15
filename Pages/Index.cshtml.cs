using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ELearningV2.Pages
{
    public class IndexModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostSignUp()
        {
            return Redirect("SignUp");
        }

        public IActionResult OnPostLogin()
        {
            return Redirect("Login");
        }
    }
}

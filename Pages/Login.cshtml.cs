using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using ELearningV2.Models;

namespace ELearningV2.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        public IActionResult OnGet()
        {
            return Page();
        }

        public LoginModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        [Required]
        public string UserName{get; set;}

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public async Task<IActionResult> OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(UserName, Password, RememberMe, false);

                if (result.Succeeded)
                {
                    return Redirect("index");
                }

                ModelState.AddModelError(String.Empty, "Invalid Email or Password");
            }

            return Page();

        }

    }
}

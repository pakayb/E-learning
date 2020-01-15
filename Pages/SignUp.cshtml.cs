using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using ELearningV2.Models;
using System.ComponentModel.DataAnnotations;


namespace ELearningV2.Pages.Users
{
    public class SignUpModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public SignUpModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostSignUp()
        {
            if (ModelState.IsValid)
            {

                var result = await _userManager.CreateAsync(User, Password);
              
                if (result.Succeeded)
                {
                    return Redirect("Login");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }

            return Page();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using ELearningV2.Models;

namespace ELearningV2.Pages
{
    public class LogOutModel : PageModel
    {
        private readonly SignInManager<User> _singInManager;

        public LogOutModel(SignInManager<User> signInManager)
        {
            _singInManager = signInManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _singInManager.SignOutAsync();
            return Redirect("Index");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ELearningV2.Context;
using ELearningV2.Models;

namespace ELearningV2.Pages.Users
{
    public class SignUpModel : PageModel
    {
        private readonly ApiContext _context;

        public SignUpModel(ApiContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public bool ValidEmail { get; set; } = true;
        [BindProperty]
        public bool ValidUsername { get; set; } = true;

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            ValidateData();
            if (ValidUsername && ValidEmail)
            {
                _context.Users.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }

        }

        private void ValidateData()
        {
            foreach (var user in _context.Users)
            {
                if (user.Email.Equals(User.Email))
                {
                    ValidEmail = false;
                    break;
                }
                else
                {
                    ValidEmail = true;
                }
                if (user.Username.Equals(User.Username))
                {
                    ValidUsername = false;
                    break;
                }
                else
                {
                    ValidUsername = true;
                }
            }
        }

    }
}

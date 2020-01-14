using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ELearningV2.Context;
using ELearningV2.Models;

namespace ELearningV2.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ApiContext _context;
        public IActionResult OnGet()
        {
            return Page();
        }

        public LoginModel(ApiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        [BindProperty]
        public bool ValidLogin { get; set; } = true;

        public async Task<IActionResult> OnPostLogin()
        {

            var userDb = await _context.Users.ToArrayAsync();
            try
            {
               User user = userDb.First(u => u.Email.Equals(User.Email));

                if (user.Password.Equals(User.Password))
                {
                    _context.ActiveUsers.Add(new Logged { UserId = user.UserId });
                    await _context.SaveChangesAsync();
                    ValidLogin = true;
                    return Redirect("Index");
                }
            }catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            ValidLogin = false;
            return Page();

        }

    }
}
 
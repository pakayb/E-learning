using System.Net;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ELearningV2.Context;

namespace ELearningV2.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly ApiContext _context;

        public UsersController(ApiContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(){
            
            var users = await _context.Users.ToListAsync();

            return View(users);
        }

    }
}
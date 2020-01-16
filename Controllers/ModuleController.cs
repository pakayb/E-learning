using System.Net;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ELearningV2.Context;
using ELearningV2.Models;
using ELearningV2.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ELearningV2.Controllers
{
    [Route("Modules")]
    public class ModuleController : Controller
    {
        // GET: /<controller>/


        private readonly ApiContext _context;
        private ModuleViewModel _vm;

        public ModuleController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet("Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var lessonsDb = await _context.Lessons.ToListAsync();
            IList<Lesson> moduleLessons = lessonsDb
                .Where(l => l.ModuleId == id)
                .Select(l => new Lesson
                {
                    Id = l.Id,
                    Title = l.Title,
                    Description = l.Description

                }).ToList();

            _vm = new ModuleViewModel { Lessons = moduleLessons };
            return View(_vm);
        }
    }
}

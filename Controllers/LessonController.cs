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
    [Route("Lessons")]
    public class LessonController : Controller
    {
        // GET: /<controller>/
        private readonly ApiContext _context;

        public LessonController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet("Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var partDb = await _context.Parts.ToListAsync();
            IList<Part> lessonParts = partDb
                .Where(p => p.LessonId == id)
                .Select(p => new Part
                {
                    PartNumber = p.PartNumber,
                    Context = p.Context
                }).ToList();

            LessonViewModel vm = new LessonViewModel { Parts = lessonParts };

            return View(vm);
        }
    }
}

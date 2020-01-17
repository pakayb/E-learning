using System.Net;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ELearningV2.Models;
using ELearningV2.Context;
using ELearningV2.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ELearningV2.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ApiContext _context;
        private IndexViewModel _vm;
        // GET: /<controller>/

        public HomeController(ApiContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //Seed();
            var modules = await _context.Modules.ToListAsync();
            _vm = new IndexViewModel { Modules = modules };
            return View(_vm);
        }

        private void Seed()
        {
            _context.Modules.Add(new Module { Title = "ProgBasic", Description = "Python" });
            _context.Modules.Add(new Module { Title = "Web-Technologies", Description = "Python" });
            _context.Modules.Add(new Module { Title = "Objectum Oriented Programing", Description = "Python" });
            _context.Modules.Add(new Module { Title = "Anvanced-Technologies", Description = "Python" });

            _context.Lessons.Add(new Lesson { Title = "Variables", Description = "A variable is nothing but a name given to a storage area that our programs can manipulate...", ModuleId = 1 });
            _context.Lessons.Add(new Lesson { Title = "Functions", Description = "A function is a block of organized, reusable code that is used to perform a single, related action.", ModuleId = 1 });
            _context.Lessons.Add(new Lesson { Title = "Flask", Description = "Flask is a micro web framework written in Python..", ModuleId = 3 });
            _context.Lessons.Add(new Lesson { Title = "Objects", Description = "A variable is nothing but a name given to a storage area that our programs can manipulate...", ModuleId = 2 });
            _context.Lessons.Add(new Lesson { Title = "Class", Description = "Classes In object-oriented programming, a class is a blueprint for creating objects , providing initial values for state, and implementations of behavior", ModuleId = 2 });
            _context.Lessons.Add(new Lesson { Title = "Razor", Description = "AngularJS is a structural framework for dynamic web apps. With AngularJS, designers can use HTML as the template language and it allows for the extension of HTML's syntax to convey the application's components effortlessly.", ModuleId = 4 });

            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 5,
                Context = "In programming, a variable is a value that can change, depending on conditions" +
    "or on information passed to the program. Typically, a program consists of instruction s " +
    "that tell the computer what to do and data that the program uses when it is running.",
                TutorialURL = "https://www.youtube.com/embed/OFrLs22MDAw"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 2,
                LessonId = 5,
                Context = "Variables can represent numeric values, characters, character strings, or memory addresses." +
                "... Variables play an important role in computer programming because they enable programmers to write flexible" +
                "programs. Rather than entering data directly into a program, a programmer can use variables to represent the data.",
                TutorialURL = "https://www.youtube.com/embed/M1h0pPFVy0E"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 6,
                Context = "In programming, a named section of a program that performs a specific task. In this sense," +
                "a function is a type of procedure or routine. Some programming languages make a distinction between a" +
                "function, which returns a value, and a procedure, which performs some operation but does not return a value.",
                TutorialURL = "https://www.youtube.com/embed/9Os0o3wzS_I"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 2,
                LessonId = 6,
                Context = "This example highlights the two most important reasons that C programmers use functions. " +
                "The first reason is reusability. Once a function is defined, it can be used over and over and over again." +
                "... Another aspect of reusability is that a single function can be used in several different (and separate) programs.",
                
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 4,
                Context = "Flask is a web application framework written in Python. Armin Ronacher, who leads an international" +
                "group of Python enthusiasts named Pocco, develops it. Flask is based on Werkzeug WSGI toolkit and Jinja2 template engine.",
                TutorialURL = "https://www.youtube.com/embed/Z1RJmh_OqeA"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 3,
                Context = "An object, in object-oriented programming (OOP), is an abstract data type created by a developer. It can include "+
                "multiple properties and methods and may even contain other objects. In most programming languages, objects are defined as classes. "+
                "Objects provide a structured approach to programming.",
                TutorialURL = "https://www.youtube.com/embed/lbXsrHGhBAU"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 1,
                Context = "In object-oriented programming, a class is an extensible program-code-template for creating objects, providing initial values"+
                "for state (member variables) and implementations of behavior (member functions or methods). ... In these languages, a class that creates classes is called a metaclass.",
                TutorialURL = "https://www.youtube.com/embed/BZ8r7pC9bHY"
            });
            _context.Parts.Add(new Part
            {

                PartNumber = 1,
                LessonId = 2,
                Context = "Razor is a markup syntax that lets you embed server-based code into web pages using C# and VB.Net. It is not a programming language."+
                "It is a server side markup language. Razor has no ties to ASP.NET MVC because Razor is a general-purpose templating engine.",
                TutorialURL = "https://www.youtube.com/embed/At_T2ciwbM0"
            });

            _context.SaveChanges();
        }
    }
}

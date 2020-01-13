using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ELearningV2.Models
{
    public class Lesson
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ModuleId { get; set; }
    }
}

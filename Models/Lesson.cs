using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningV2.Models
{
    public class Lesson
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string Body { get; set; }
        //public long UserId { get; set; }
        public int PartNumber { get; set; }
        //public DateTime Date { get; set; }
    }
}

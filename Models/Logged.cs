using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ELearningV2.Models
{
    public class Logged
    {
        public long Id { get; set; }
        public long UserId { get; set; }
    }
}
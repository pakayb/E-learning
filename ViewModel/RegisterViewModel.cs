using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningV2.Models;
using System.ComponentModel.DataAnnotations;

namespace ELearningV2.ViewModel
{
    public class RegisterViewModel
    {

        public User User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

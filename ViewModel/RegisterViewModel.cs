﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningV2.Models;
using System.ComponentModel.DataAnnotations;

namespace ELearningV2.ViewModel
{
    public class RegisterViewModel
    {


        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required, DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

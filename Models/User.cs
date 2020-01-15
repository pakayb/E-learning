using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ELearningV2.Models
{
    public class User : IdentityUser 
    {

        [Required, StringLength(15)]
        public string FirstName { get; set; }
        [Required, StringLength(15)]
        public string LastName { get; set; }
        public long ReachedPartId { get; set; }

    }
}

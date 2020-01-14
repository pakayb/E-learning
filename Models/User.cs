using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ELearningV2.Models
{
    public class User
    {
        public long UserId { get; set; }
        [Required, StringLength(15)]
        public string FirstName { get; set; }
        [Required, StringLength(15)]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public long ReachedPartId { get; set; }

    }
}

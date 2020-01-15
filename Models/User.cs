using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ELearningV2.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required, StringLength(15)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(15)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public long ReachedPartId { get; set; }

    }
}

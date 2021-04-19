using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDemoMVC.Models
{
    public class RegistrationModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$")]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]*$")]
        [StringLength(20, MinimumLength = 3)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

    }
}
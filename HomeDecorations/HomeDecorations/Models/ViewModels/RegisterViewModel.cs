using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorations.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be atleaset {2} characters long.", MinimumLength = 10)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be atleaset {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]

        [Compare("Password", ErrorMessage = "The Password and confirm pasword donot match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}

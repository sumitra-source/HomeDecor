using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorations.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = " Forgot Password?")]
        public bool ForgotPassword { get; set; }
    }
}

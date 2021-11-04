using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "A Username is required. How else would we refer to you?")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The username must be between 5 and 15 characters. That one's kind of arbitrary, to be fair...")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "A password is required. How else would we know it's you?")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The password must be between 6 and 20 characters. Longer passwords make it harder for people to steal your account!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password verification is required. It'll help you verify you typed it right!")]
        [Compare("Password", ErrorMessage = "Your entry in this field didn't match your entry in the password field.")]
        public string VerifyPassword { get; set; }
    }
}
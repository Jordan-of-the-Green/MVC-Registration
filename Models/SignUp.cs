using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVC_Registration.Models
{
    public partial class SignUp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Username")] // If user doesnt type value in; will display error
        [Display(Name = "Username")]  // Title
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password")] // If user doesnt type value in; will display error
        [Display(Name = "Password")]  // Title
        [DataType(DataType.Password)] // Blackens the password
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "min 3, max 50 letters")]
        public string Password { get; set; }
    }
}

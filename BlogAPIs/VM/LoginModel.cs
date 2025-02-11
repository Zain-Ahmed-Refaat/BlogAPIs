﻿using System.ComponentModel.DataAnnotations;

namespace BlogAPIs.VM
{
    public class LoginModel
    {

        [Required]
        [EmailAddress]
        public string Email {  get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
    }
}

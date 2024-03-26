﻿using System.ComponentModel.DataAnnotations;

namespace BloggieToBike.Web.Models.ViewModels
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}

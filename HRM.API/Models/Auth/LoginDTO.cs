﻿namespace HRM.API.Models.Auth
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

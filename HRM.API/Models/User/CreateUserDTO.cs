using System;
using HRM.API.Models.Employee;

namespace HRM.API.Models.User
{
    public class CreateUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public CreateEmployeeDTO Employee { get; set; }
    }
}

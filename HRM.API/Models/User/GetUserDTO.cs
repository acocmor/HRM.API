using System;
using HRM.API.Models.Employee;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.User
{
    public class GetUserDTO
    {
        public IKey Id { get; set; }
        public string Email { get; set; }
        public GetEmployeeDTO Employee { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
    }
}

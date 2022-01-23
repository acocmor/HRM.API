using System;
using HRM.API.Models.Address;
using HRM.API.Models.Department;
using HRM.API.Models.Gender;
using HRM.API.Models.Position;
using HRM.API.Models.User;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.Employee
{
    public class GetEmployeeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DayOfBirth { get; set; }
        public int MonthOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public string Avatar { get; set; }
        public GetGenderDTO Gender { get; set; }
        public GetUserDTO User { get; set; }
        public GetAddressDTO Address { get; set; }
        public virtual GetPositionDTO Position { get; set; }
        public virtual GetDepartmentDTO Department { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
    }
}

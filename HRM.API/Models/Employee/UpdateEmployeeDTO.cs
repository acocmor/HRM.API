using HRM.API.Models.Address;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.Employee
{
    public class UpdateEmployeeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DayOfBirth { get; set; }
        public int MonthOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public string Avatar { get; set; }
        public IKey GenderId { get; set; }
        public UpdateAddressDTO Address { get; set; }
        public IKey? PositionId { get; set; }
        public IKey? DepartmentId { get; set; }
    }
}

using HRM.Entity.Common;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.Entity.Entities
{
    public class Employee : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DayOfBirth { get; set; }
        public int MonthOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public string? Avatar { get; set; }
        public IKey GenderId { get; set; }
        public Gender Gender { get; set; }
        public IKey UserId { get; set; }
        public User User { get; set; }
        public Address Address { get; set; }
        public IKey? PositionId { get; set; }
        public Position Position { get; set; }
        public IKey? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

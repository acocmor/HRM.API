using System;
using HRM.API.Models.Employee;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.Address
{
    public class GetAddressDTO
    {
        public IKey Id { get; set; }
        public string Detail { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public GetEmployeeDTO Employee { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
        
    }
}

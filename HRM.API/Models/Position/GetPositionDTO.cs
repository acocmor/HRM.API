using System;
using System.Collections.Generic;
using HRM.API.Models.Employee;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.Position
{
    public class GetPositionDTO
    {
        public IKey Id { get; set; }
        public string Name { get; set; }
        public ICollection<GetEmployeeDTO> Employees { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime UpdatedAt { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace HRM.Entity.Common
{
    public class EntityBase
    {
        public IKey Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

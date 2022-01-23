using HRM.Entity.Common;

namespace HRM.Entity.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
    }
}

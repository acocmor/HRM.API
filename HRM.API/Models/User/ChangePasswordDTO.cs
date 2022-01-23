using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.User
{
    public class ChangePasswordDTO
    {
        public IKey Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}

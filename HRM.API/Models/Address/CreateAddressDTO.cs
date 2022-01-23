using Microsoft.EntityFrameworkCore.Metadata;

namespace HRM.API.Models.Address
{
    public class CreateAddressDTO
    {
        public string Detail { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public IKey EmployeeId { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace CarRental.DAL.Entities
{
    public class AppRole:IdentityRole<int>
    {
        public string? RoleDetail { get; set; }
    }
}

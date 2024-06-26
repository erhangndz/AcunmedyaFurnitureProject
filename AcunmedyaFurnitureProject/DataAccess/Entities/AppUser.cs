using Microsoft.AspNetCore.Identity;

namespace AcunmedyaFurnitureProject.DataAccess.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string? ImageUrl { get; set; }

    }
}

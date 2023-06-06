using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string NameRu { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
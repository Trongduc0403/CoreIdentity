using Microsoft.AspNetCore.Identity;

namespace CoreIdentity.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public Role() : base() { }
        public Role(string roleName) : base(roleName) { }

        // Navigation properties
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<IdentityRoleClaim<string>> RoleClaims { get; set; }
    }
}

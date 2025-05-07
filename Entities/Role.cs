using Microsoft.AspNetCore.Identity;

namespace CoreIdentity.Entities
{
    public class Role : IdentityRole
    {
        public Role() : base() { }
        public Role(string roleName) : base(roleName) { }

        // Navigation properties
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
        public virtual ICollection<IdentityRoleClaim<string>> RoleClaims { get; set; }
    }
}

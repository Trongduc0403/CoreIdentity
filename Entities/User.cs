using Microsoft.AspNetCore.Identity;

namespace CoreIdentity.Entities
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; }
        public string? AvatarUrl { get; set; }

        // Navigation properties
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace CoreIdentity.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}

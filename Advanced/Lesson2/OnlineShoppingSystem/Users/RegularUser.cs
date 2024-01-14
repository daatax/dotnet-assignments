using System;

namespace OnlineShoppingSystem.Users
{
    public class RegularUser : UserManager
    {
        public RegularUser() : base() { }

        public RegularUser(ImmutableUserContext immutableUserContext)
            : base(immutableUserContext) { }
    }
}

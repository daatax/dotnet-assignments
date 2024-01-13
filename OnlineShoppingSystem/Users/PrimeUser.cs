using System;

namespace OnlineShoppingSystem.Users
{
    public class PrimeUser : UserManager
    {
        public PrimeUser() : base() { }

        public PrimeUser(ImmutableUserContext immutableUserContext)
            : base(immutableUserContext) { }
    }
}

using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Helpers.Validators;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Users
{
    public class UserBuilder
    {
        private ImmutableUserContext immutableUserContext = new ImmutableUserContext();

        public UserBuilder()
        {
            immutableUserContext.UserID = Utils.GenerateID();
            immutableUserContext.UserStatus = UserExecutionStatus.NotVerified;
        }

        public UserBuilder SetUsername(string username)
        {
            if (!username.IsValidUsername(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutableUserContext.Username = username;
            return this;
        }

        public UserBuilder SetFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName)) {
                throw new ArgumentException($"'{nameof(firstName)}' cannot be null or empty.");
            }
            immutableUserContext.FirstName = firstName;
            return this;
        }

        public UserBuilder SetLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName)) {
                throw new ArgumentException($"'{nameof(lastName)}' cannot be null or empty.");
            }
            immutableUserContext.LastName = lastName;
            return this;
        }

        public UserBuilder SetBirthDate(DateOnly? birthDate)
        {
            if (birthDate.HasValue && birthDate.Value > DateOnly.FromDateTime(DateTime.Now)) {
                throw new ArgumentException($"'{nameof(birthDate)}' cannot be in the future.");
            }
            immutableUserContext.BirthDate = birthDate;
            return this;
        }

        public UserBuilder SetPhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.IsValidPhoneNumber(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutableUserContext.PhoneNumber = phoneNumber;
            return this;
        }

        public UserBuilder SetEmailAddress(string emailAddress)
        {
            if (!emailAddress.IsValidEmailAddress(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutableUserContext.EmailAddress = emailAddress;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            if (!password.IsValidPassword(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutableUserContext.Password = password;
            return this;
        }

        public UserManager Build(UserManager user)
        {
            Utils.ValidateRequiredFields(immutableUserContext.requiredFields, immutableUserContext);
            if (user is RegularUser) {
                return new RegularUser(immutableUserContext);
            }
            else if (user is PrimeUser) {
                return new PrimeUser(immutableUserContext);
            }
            else {
                throw new ArgumentException($"Unsupported User type: '{nameof(user)}'");
            }
        }
    }
}
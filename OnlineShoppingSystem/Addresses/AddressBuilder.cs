using OnlineShoppingSystem.Users;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Helpers.Validators;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Addresses
{
    public class AddressBuilder
    {
        private ImmutableAddressContext immutableAddressContext = new ImmutableAddressContext();

        public AddressBuilder()
        {
            immutableAddressContext.AddressID = Utils.GenerateID();
            immutableAddressContext.AddressStatus = AddressExecutionStatus.NotValidated;
        }

        public AddressBuilder SetAddressStreet(string addressStreet)
        {
            if (string.IsNullOrEmpty(addressStreet)) {
                throw new ArgumentNullException($"'{nameof(addressStreet)}' cannot be null or empty.");
            }
            immutableAddressContext.AddressStreet = addressStreet;
            return this;
        }

        public AddressBuilder SetAddressUnit(string addressUnit)
        {
            immutableAddressContext.AddressUnit = addressUnit;
            return this;
        }

        public AddressBuilder SetAddressCity(string addressCity)
        {
            if (string.IsNullOrEmpty(addressCity)) {
                throw new ArgumentNullException($"'{nameof(addressCity)}' cannot be null or empty.");
            }
            immutableAddressContext.AddressCity = addressCity;
            return this;
        }

        public AddressBuilder SetAddressState(string addressState)
        {
            if (string.IsNullOrEmpty(addressState)) {
                throw new ArgumentNullException($"'{nameof(addressState)}' cannot be null or empty.");
            }
            immutableAddressContext.AddressState = addressState;
            return this;
        }

        public AddressBuilder SetAddressZipCode(string addressZipCode)
        {
            if (!addressZipCode.IsValidZipCode(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutableAddressContext.AddressZipCode = addressZipCode;
            return this;
        }

        public AddressBuilder SetAddressCountry(string addressCountry)
        {
            if (string.IsNullOrEmpty(addressCountry)) {
                throw new ArgumentNullException($"'{nameof(addressCountry)}' cannot be null or empty.");
            }
            immutableAddressContext.AddressCountry = addressCountry;
            return this;
        }

        public AddressManager Build(AddressManager address, UserManager user)
        {
            if (user == null) {
                throw new ArgumentNullException($"The '{nameof(user)}' parameter cannot be null.");
            }

            Utils.ValidateRequiredFields(immutableAddressContext.requiredFields, immutableAddressContext);
            immutableAddressContext.User = user;
            if (address is BillingAddress) {
                BillingAddress billingAddress = new BillingAddress(immutableAddressContext, user);
                user.SetBillingAddress(billingAddress);

                return billingAddress;
            }
            else if (address is ShippingAddress) {
                ShippingAddress shippingAddress = new ShippingAddress(immutableAddressContext, user);
                user.AddShippingAddress(shippingAddress);

                return shippingAddress;
            }
            else {
                throw new ArgumentException("Unsupported Address type: ", nameof(address));
            }
        }
    }
}
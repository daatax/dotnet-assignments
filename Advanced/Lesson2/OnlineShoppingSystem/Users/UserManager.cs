using System.Text;
using OnlineShoppingSystem.Orders;
using OnlineShoppingSystem.Payment;
using OnlineShoppingSystem.Addresses;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Users
{
    public class UserManager
    {
        private readonly ImmutableUserContext immutableUserContext;

        // Immutable Context
        public string UserID => immutableUserContext.UserID;
        public string Username => immutableUserContext.Username;
        public string FirstName => immutableUserContext.FirstName;
        public string LastName => immutableUserContext.LastName;
        public DateOnly? BirthDate => immutableUserContext.BirthDate;
        public string PhoneNumber => immutableUserContext.PhoneNumber;
        public string EmailAddress => immutableUserContext.EmailAddress;
        public string Password => immutableUserContext.Password;
        public UserExecutionStatus UserStatus => immutableUserContext.UserStatus;

        public BillingAddress BillingAddress { get; private set; }
        public List<ShippingAddress> ShippingAddresses { get; private set; }
        public List<PaymentMethodManager> PaymentMethods { get; private set; }
        public List<OrderManager> Orders { get; private set; }

        public UserManager() { }

        public UserManager(ImmutableUserContext immutableUserContext)
        {
            this.immutableUserContext = immutableUserContext;
            this.ShippingAddresses = new List<ShippingAddress>();
            this.PaymentMethods = new List<PaymentMethodManager>();
        }

        public void SetBillingAddress(BillingAddress billingAddress)
        {
            if (this.BillingAddress != null) {
                throw new InvalidOperationException($"User can have only one Billing Address. {UpdateBillingAddress} can be used.");
            }
            this.BillingAddress = billingAddress;
        }

        public void UpdateBillingAddress(BillingAddress billingAddress)
        {
            this.BillingAddress = billingAddress;
        }

        public void AddShippingAddress(ShippingAddress shippingAddress)
        {
            if (shippingAddress == null) {
                throw new ArgumentNullException($"'{nameof(shippingAddress)}' cannot be null");
            }
            this.ShippingAddresses.Add(shippingAddress);
        }

        public void RemoveShippingAddress(ShippingAddress shippingAddress)
        {
            if (shippingAddress == null) {
                throw new ArgumentNullException($"'{nameof(shippingAddress)}' cannot be null");
            }
            this.ShippingAddresses.Remove(shippingAddress);
        }

        public void AddPaymentMethod(PaymentMethodManager paymentMethod)
        {
            if (paymentMethod == null) {
                throw new ArgumentNullException($"'{nameof(paymentMethod)}' cannot be null");
            }
            this.PaymentMethods.Add(paymentMethod);
        }

        public void RemovePaymentMethod(PaymentMethodManager paymentMethod)
        {
            if (paymentMethod == null) {
                throw new ArgumentNullException($"'{nameof(paymentMethod)}' cannot be null");
            }
            this.PaymentMethods.Remove(paymentMethod);
        }

        public string GetUserFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        // TODO: immplement a real password hashing
        private string HashPassword(ImmutableUserContext immutableUserContext)
        {
            return "";
        }

        // TODO: implement a method where the status will be updated under certain conditians
        public void UpdateUserStatus(UserExecutionStatus status)
        {
            immutableUserContext.UserStatus = status;
        }

        // Implement all these 
        public void PlaceOrder() { }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(UserID)}={{{UserID}}}");
            stringBuilder.AppendLine($"{nameof(Username)}={{{Username}}}");
            stringBuilder.AppendLine($"{nameof(FirstName)}={{{FirstName}}}");
            stringBuilder.AppendLine($"{nameof(LastName)}={{{LastName}}}");
            stringBuilder.AppendLine($"{nameof(BirthDate)}={{{BirthDate}}}");
            stringBuilder.AppendLine($"{nameof(PhoneNumber)}={{{PhoneNumber}}}");
            stringBuilder.AppendLine($"{nameof(EmailAddress)}={{{EmailAddress}}}");
            stringBuilder.AppendLine($"{nameof(UserStatus)}={{{UserStatus}}}");

            return stringBuilder.ToString();
        }
    }

    public class ImmutableUserContext
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public UserExecutionStatus UserStatus { get; set; }

        public List<string> requiredFields = new List<string> {
            "Username", "FirstName", "LastName", "PhoneNumber", "EmailAddress","Password"
        };
    }

    public enum UserExecutionStatus
    {
        NotVerified,
        Active,
        Blocked,
        Deleted
    }
}
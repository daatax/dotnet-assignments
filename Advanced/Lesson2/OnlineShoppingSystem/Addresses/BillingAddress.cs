using System.Text;
using OnlineShoppingSystem.Users;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Addresses
{
    public class BillingAddress : AddressManager
    {
        public string BillToName { get; set; }
        public bool IsTaxable { get; set; }

        public BillingAddress() : base() { }

        public BillingAddress(ImmutableAddressContext immutableAddressContext, UserManager user)
            : base(immutableAddressContext, user)
        {
            BillToName = $"{user.FirstName} {user.LastName} - {immutableAddressContext.AddressStreet}";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(AddressID)}={{{AddressID}}}");
            stringBuilder.AppendLine($"{nameof(User)}={{{User.ToString()}}}");
            stringBuilder.AppendLine($"{nameof(AddressStreet)}={{{AddressStreet}}}");
            stringBuilder.AppendLine($"{nameof(AddressUnit)}={{{AddressUnit}}}");
            stringBuilder.AppendLine($"{nameof(AddressCity)}={{{AddressCity}}}");
            stringBuilder.AppendLine($"{nameof(AddressState)}={{{AddressState}}}");
            stringBuilder.AppendLine($"{nameof(AddressZipCode)}={{{AddressZipCode}}}");
            stringBuilder.AppendLine($"{nameof(AddressCountry)}={{{AddressCountry}}}");
            stringBuilder.AppendLine($"{nameof(AddressStatus)}={{{AddressStatus}}}");
            stringBuilder.AppendLine($"{nameof(BillToName)}={{{BillToName}}}");

            return stringBuilder.ToString();
        }
    }
}

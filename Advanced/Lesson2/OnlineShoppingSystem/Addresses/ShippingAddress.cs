using System.Text;
using OnlineShoppingSystem.Users;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Addresses
{
    public class ShippingAddress : AddressManager
    {
        public string LocationName { get; set; }
        public string RecipientName { get; set; }
        public string? DeliveryInstructions { get; set; }

        public ShippingAddress() : base() { }

        public ShippingAddress(ImmutableAddressContext immutableAddressContext, UserManager user)
            : base(immutableAddressContext, user)
        {
            this.LocationName = $"{user.FirstName} {user.LastName} - {immutableAddressContext.AddressStreet}";
            this.RecipientName = $"{user.FirstName} {user.LastName}";
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
            stringBuilder.AppendLine($"{nameof(LocationName)}={{{LocationName}}}");
            stringBuilder.AppendLine($"{nameof(RecipientName)}={{{RecipientName}}}");
            stringBuilder.AppendLine($"{nameof(DeliveryInstructions)}={{{DeliveryInstructions}}}");

            return stringBuilder.ToString();
        }
    }
}

using OnlineShoppingSystem.Users;
using System.Text;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Addresses
{
    public class AddressManager
    {
        private readonly ImmutableAddressContext immutableAddressContext;
        private readonly UserManager user;

        // Immutable Context
        public string AddressID => immutableAddressContext.AddressID;
        public UserManager User => immutableAddressContext.User;
        public string AddressStreet => immutableAddressContext.AddressStreet;
        public string AddressUnit => immutableAddressContext.AddressUnit;
        public string AddressCity => immutableAddressContext.AddressCity;
        public string AddressState => immutableAddressContext.AddressState;
        public string AddressZipCode => immutableAddressContext.AddressZipCode;
        public string AddressCountry => immutableAddressContext.AddressCountry;
        public AddressExecutionStatus AddressStatus => immutableAddressContext.AddressStatus;

        public AddressManager() { }

        public AddressManager(ImmutableAddressContext immutableAddressContext, UserManager user)
        {
            this.immutableAddressContext = immutableAddressContext;
            this.user = user;
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

            return stringBuilder.ToString();
        }
    }

    public class ImmutableAddressContext
    {
        public string AddressID { get; set; }
        public UserManager User { get; set; }
        public string AddressStreet { get; set; }
        public string AddressUnit { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZipCode { get; set; }
        public string AddressCountry { get; set; }
        public AddressExecutionStatus AddressStatus { get; set; }

        public List<string> requiredFields = new List<string> {
            "AddressStreet", "AddressCity", "AddressState", "AddressZipCode", "AddressCountry"
        };
    }

    public enum AddressExecutionStatus
    {
        NotValidated,
        Validated
    }
}

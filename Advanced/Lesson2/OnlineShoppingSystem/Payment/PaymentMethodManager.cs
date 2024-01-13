using System.Text;
using OnlineShoppingSystem.Users;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Payment
{
    public class PaymentMethodManager
    {
        private ImmutablePaymentContext immutablePaymentContext = new ImmutablePaymentContext();
        private readonly UserManager user;

        public string PaymentID => immutablePaymentContext.PaymentID;
        public UserManager User => immutablePaymentContext.User;
        private string CardNumber => immutablePaymentContext.CardNumber;
        public string CardHolderName => immutablePaymentContext.CardHolderName;
        public string CardName => immutablePaymentContext.CardName;
        private short CardExpirationMonth => immutablePaymentContext.CardExpirationMonth;
        private short CardExpirationYear => immutablePaymentContext.CardExpirationYear;
        private short CardCVV => immutablePaymentContext.CardCVV;

        public PaymentMethodManager(ImmutablePaymentContext immutablePaymentContext, UserManager user)
        {
            this.immutablePaymentContext = immutablePaymentContext;
            this.user = user;
        }

        public string ShowCardNumber()
        {
            return $"{CardNumber.Substring(0, 4)}********{CardNumber.Substring(12, 4)}";
        }

        // TODO:
        // Implement a real hashing
        // move by demand to other class
        public void HashCardNumber() { }
        public void HashCardExpirationDay() { }
        public void HashCardExpirationMonth() { }
        public void HashCardCVV() { }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(PaymentID)}={{{PaymentID}}}");
            stringBuilder.AppendLine($"{nameof(User)}={{{User.ToString()}}}");
            stringBuilder.AppendLine($"{nameof(CardNumber)}={{{ShowCardNumber()}}}");
            stringBuilder.AppendLine($"{nameof(CardHolderName)}={{{CardHolderName}}}");
            stringBuilder.AppendLine($"{nameof(CardName)}={{{CardName}}}");
            stringBuilder.AppendLine($"{nameof(CardExpirationMonth)}={{{"**"}}}");
            stringBuilder.AppendLine($"{nameof(CardExpirationYear)}={{{"**"}}}");
            stringBuilder.AppendLine($"{nameof(CardCVV)}={{{"***"}}}");

            return stringBuilder.ToString();
        }
    }

    public class ImmutablePaymentContext
    {
        public string PaymentID { get; set; }
        public UserManager User { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardName { get; set; }
        public short CardExpirationMonth { get; set; }
        public short CardExpirationYear { get; set; }
        public short CardCVV { get; set; }

        public List<string> requiredFields = new List<string> {
            "CardNumber", "CardHolderName", "CardExpirationYear", "CardExpirationMonth", "CardCVV"
        };
    }
}

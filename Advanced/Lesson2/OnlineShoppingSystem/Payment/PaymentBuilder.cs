using OnlineShoppingSystem.Users;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Helpers.Validators;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Payment
{
    public class PaymentBuilder
    {
        private ImmutablePaymentContext immutablePaymentContext = new ImmutablePaymentContext();

        public PaymentBuilder()
        {
            immutablePaymentContext.PaymentID = Utils.GenerateID();
        }

        public PaymentBuilder SetCardNumber(string cardNumber)
        {
            if (!cardNumber.IsValidCreditCard(out string errorMessage)) {
                throw new ArgumentException(errorMessage);
            }
            immutablePaymentContext.CardNumber = cardNumber;
            return this;
        }

        public PaymentBuilder SetCardHolderName(string cardHolderName)
        {
            if (string.IsNullOrEmpty(cardHolderName)) {
                throw new ArgumentException($"'{nameof(cardHolderName)}' cannot be null or empty.");
            }
            immutablePaymentContext.CardHolderName = cardHolderName;
            return this;
        }

        public PaymentBuilder SetCardName(string cardName)
        {
            immutablePaymentContext.CardName = cardName;
            return this;
        }

        public PaymentBuilder SetCardExpirationMonth(short cardExpirationMonth)
        {
            if (cardExpirationMonth < 1 || cardExpirationMonth > 12) {
                throw new ArgumentException($"'{nameof(cardExpirationMonth)}' is invalid.");
            }
            immutablePaymentContext.CardExpirationMonth = cardExpirationMonth;
            return this;
        }

        public PaymentBuilder SetCardExpirationYear(short cardExpirationYear)
        {
            if (cardExpirationYear == DateTime.Now.Year
                    && immutablePaymentContext.CardExpirationMonth < DateTime.Now.Month) {
                throw new ArgumentException($"Invalid credit card expiration date: '{immutablePaymentContext.CardExpirationMonth}'; '{nameof(cardExpirationYear)}'");
            }
            if (cardExpirationYear < DateTime.Now.Year) {
                throw new ArgumentException($"'{nameof(cardExpirationYear)}' cannot be less than the current year.");
            }
            if (cardExpirationYear > DateTime.Now.Year + 5) {
                throw new ArgumentException($"'{nameof(cardExpirationYear)}' cannot be more than {DateTime.Now.Year + 5}.");
            }
            immutablePaymentContext.CardExpirationYear = cardExpirationYear;
            return this;
        }

        public PaymentBuilder SetCardCVV(short cardCVV)
        {
            if (cardCVV.ToString().Length != 3) {
                throw new ArgumentException($"Length of '{nameof(cardCVV)}' cannot be less or greater than 3.");
            }
            immutablePaymentContext.CardCVV = cardCVV;
            return this;
        }

        public PaymentMethodManager Build(UserManager user)
        {
            if (user == null) {
                throw new ArgumentNullException($"The '{nameof(user)}' parameter cannot be null.");
            }
            Utils.ValidateRequiredFields(immutablePaymentContext.requiredFields, immutablePaymentContext);
            immutablePaymentContext.User = user;

            return new PaymentMethodManager(immutablePaymentContext, user);

        }
    }
}

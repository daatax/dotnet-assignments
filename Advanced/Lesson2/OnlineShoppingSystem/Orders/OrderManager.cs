using System.Text;
using OnlineShoppingSystem.Cart;
using OnlineShoppingSystem.Payment;
using OnlineShoppingSystem.Addresses;
using OnlineShoppingSystem.Helpers;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Orders
{
    public class OrderManager
    {
        private ShoppingCartManager shoppingCart;
        private ShippingAddress shippingAddress;
        private PaymentMethodManager paymentMethod;

        public string OrderID { get; private set; }
        public int OrderNumber { get; private set; }
        public DateTime OrderDate { get; private set; }
        public OrderPlacementStatus OrderStatus { get; private set; }
        public DateTime ShippingDate { get; private set; }
        public DateTime DeliveryDate { get; private set; }

        public OrderManager(ShoppingCartManager shoppingCart)
        {
            this.OrderID = Utils.GenerateID();
            this.OrderNumber = new Random().Next(100000, 9999999);
            this.OrderDate = DateTime.Now;
            this.OrderStatus = OrderPlacementStatus.Pending;

            this.shoppingCart = shoppingCart;
        }

        public void SelectShippingAddress(ShippingAddress shippingAddress)
        {
            if (!this.shoppingCart.User.ShippingAddresses.Contains(shippingAddress)) {
                throw new ArgumentException($"The provided Shipping Address is not associated with the current User's shipping addresses.");
            }
            this.shippingAddress = shippingAddress;
        }

        public void SelectPaymentMethod(PaymentMethodManager paymentMethod)
        {
            if (!shoppingCart.User.PaymentMethods.Contains(paymentMethod)) {
                throw new ArgumentException($"The provided Payment Method is not associated with the current User's payment methods.");
            }
            this.paymentMethod = paymentMethod;
        }

        public void ConfirmOrder()
        {
            if (this.shippingAddress == null || this.paymentMethod == null) {
                throw new ArgumentNullException("One or more required components (shipping address, payment method) are missing.");
            }
            UpdateOrderStatus(OrderPlacementStatus.Processing);
            SetShippingDate();
            SetDeliveryDate();
        }

        private void UpdateOrderStatus(OrderPlacementStatus orderStatus)
        {
            this.OrderStatus = orderStatus;
        }

        private void SetShippingDate()
        {
            this.ShippingDate = this.OrderDate.AddDays(3);
        }

        private void SetDeliveryDate()
        {
            this.DeliveryDate = this.ShippingDate.AddDays(2);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(OrderID)}={{{OrderID}}}");
            stringBuilder.AppendLine($"{nameof(OrderNumber)}={{{OrderNumber}}}");
            stringBuilder.AppendLine($"{nameof(OrderDate)}={{{OrderDate}}}");
            stringBuilder.AppendLine($"{nameof(ShippingDate)}={{{ShippingDate}}}");
            stringBuilder.AppendLine($"{nameof(DeliveryDate)}={{{DeliveryDate}}}");
            stringBuilder.AppendLine($"{nameof(OrderStatus)}={{{OrderStatus}}}");

            return stringBuilder.ToString();
        }
    }

    public enum OrderPlacementStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Canceled
    }
}
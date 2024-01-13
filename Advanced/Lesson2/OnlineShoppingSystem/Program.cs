using OnlineShoppingSystem.Cart;
using OnlineShoppingSystem.Users;
using OnlineShoppingSystem.Payment;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Products;
using OnlineShoppingSystem.Addresses;
using OnlineShoppingSystem.Orders;

namespace OnlineShoppingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try {
                RegularUser regularUser = (RegularUser) new UserBuilder()
                    .SetUsername("regularUser")
                    .SetFirstName("John")
                    .SetLastName("Doe")
                    .SetBirthDate(new DateOnly(1992, 7, 23))
                    .SetEmailAddress("john.doe@domanin.com")
                    .SetPassword("Pas$word303")
                    .SetPhoneNumber("8081314567")
                    .Build(new RegularUser());

                Console.WriteLine($"Printing {nameof(regularUser)} details ...");
                Console.WriteLine(regularUser.ToString());

                PrimeUser primeUser = (PrimeUser) new UserBuilder()
                    .SetUsername("primeUser")
                    .SetFirstName("Lorem")
                    .SetLastName("Impsum")
                    .SetBirthDate(new DateOnly(1990, 10, 17))
                    .SetEmailAddress("lorem@ipsum.com")
                    .SetPassword("Pas$word303")
                    .SetPhoneNumber("8081314567")
                    .Build(new PrimeUser());

                Console.WriteLine($"Printing {nameof(primeUser)} details ...");
                Console.WriteLine(primeUser.ToString());

                BillingAddress billingAddress = (BillingAddress) new AddressBuilder()
                    .SetAddressStreet("123 Main Road")
                    .SetAddressCity("Philadelphia")
                    .SetAddressState("PA")
                    .SetAddressZipCode("12345-1234")
                    .SetAddressCountry("USA")
                    .Build(new BillingAddress(), regularUser);

                Console.WriteLine($"Printing {nameof(billingAddress)} details ...");
                Console.WriteLine(billingAddress.ToString());

                ShippingAddress shippingAddress = (ShippingAddress) new AddressBuilder()
                    .SetAddressStreet("5th Avenue")
                    .SetAddressCity("Brooklyn")
                    .SetAddressState("NY")
                    .SetAddressZipCode("54321-4321")
                    .SetAddressCountry("USA")
                    .Build(new ShippingAddress(), regularUser);

                Console.WriteLine($"Printing {nameof(shippingAddress)} details ...");
                Console.WriteLine(shippingAddress.ToString());

                ShippingAddress shippingAddress2 = (ShippingAddress) new AddressBuilder()
                    .SetAddressStreet("800 North Blvd")
                    .SetAddressCity("San Ramon")
                    .SetAddressState("CA")
                    .SetAddressZipCode("67890-9876")
                    .SetAddressCountry("USA")
                    .Build(new ShippingAddress(), regularUser);

                Console.WriteLine($"Printing {nameof(shippingAddress2)} details ...");
                Console.WriteLine(shippingAddress2.ToString());

                PaymentMethodManager paymentMethod = new PaymentBuilder()
                    .SetCardNumber("5410120100025410")
                    .SetCardHolderName("John Doe")
                    .SetCardExpirationMonth(8)
                    .SetCardExpirationYear(2025)
                    .SetCardCVV(459)
                    .Build(regularUser);

                regularUser.AddPaymentMethod(paymentMethod);

                Console.WriteLine($"Printing {nameof(paymentMethod)} details ...");
                Console.WriteLine(paymentMethod.ToString());

                ProductManager product1 = new ProductBuilder()
                    .SetProductTitle("CREED Aventus Cologne")
                    .SetProductDescription("Aventus is a fruity/rich blend featuring pineapple, birch, and ambergris made for individuals who " +
                                            "savor a life well-lived.Base notes are Musk, oak moss, Ambergris and Vanille")
                    .SetPrice(453.89)
                    .SetTotalQuantity(8)
                    .SetMinQuantityPerOrder(1)
                    .Build();

                Console.WriteLine($"Printing {nameof(product1)} details ...");
                Console.WriteLine(product1.ToString());

                ShoppingCartManager shoppingCart = new ShoppingCartManager(regularUser, product1);

                ProductManager product2 = new ProductBuilder()
                    .SetProductTitle("Logitech MX Master 3S")
                    .SetProductDescription("Logitech MX Master 3S Performance Wireless Mouse Introducing Logitech MX Master 3S – an iconic mouse remastered.")
                    .SetPrice(99.99)
                    .SetTotalQuantity(12)
                    .SetMinQuantityPerOrder(1)
                    .Build();

                Console.WriteLine($"Printing {nameof(product2)} details ...");
                Console.WriteLine(product2.ToString());

                shoppingCart.AddProduct(product2);

                Console.WriteLine($"Printing {nameof(shoppingCart)} details ...");
                Console.WriteLine(shoppingCart.ToString());

                shoppingCart.SelectProductsForOrder(new List<ProductManager> { product1, product2 });

                OrderManager order = shoppingCart.Checkout(shoppingCart.Products);

                order.SelectShippingAddress(shippingAddress);
                order.SelectPaymentMethod(paymentMethod);
                order.ConfirmOrder();

                Console.WriteLine($"Printing {nameof(order)} details ...");
                Console.WriteLine(order.ToString());
            }
            catch (Exception e) {
                Console.WriteLine(Utils.GetFormattedExceptionDetails(e));
            }
        }
    }
}
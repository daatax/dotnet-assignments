using OnlineShoppingSystem.Users;
using OnlineShoppingSystem.Products;
using OnlineShoppingSystem.Helpers;
using System.Text;
using OnlineShoppingSystem.Orders;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Cart
{
    public class ShoppingCartManager
    {
        public string ShoppingCartId { get; private set; }
        public int ItemCount { get; private set; }
        public Dictionary<ProductManager, bool> Products { get; private set; }
        public UserManager User { get; private set; }

        public ShoppingCartManager(UserManager user, ProductManager product)
        {
            this.ShoppingCartId = Utils.GenerateID();
            this.User = user;
            this.Products = new Dictionary<ProductManager, bool>();
            this.AddProduct(product);
        }

        public void AddProduct(ProductManager product)
        {
            if (product == null) {
                throw new ArgumentNullException($"'{nameof(product)}' cannot be null");
            }
            this.Products.Add(product, false);
            this.ItemCount++;
        }

        public void RemoveProduct(ProductManager product)
        {
            if (product == null) {
                throw new ArgumentNullException($"'{nameof(product)}' cannot be null");
            }
            this.Products.Remove(product);
            this.ItemCount--;
        }

        public void ClearShoppingCart()
        {
            if (this.Products.Count != 0) {
                this.Products.Clear();
                this.ItemCount = 0;
            }
        }

        public void SelectProductsForOrder(List<ProductManager> products)
        {
            if (products != null) {
                foreach (var product in products) {
                    this.Products[product] = true;
                }
            }
        }

        public OrderManager Checkout(Dictionary<ProductManager, bool> selectedProducts)
        {
            if (selectedProducts.Count == 0) {
                throw new ArgumentException("cannot have 0 selected products, and remind to use the SelectProductsForOrder");
            }
            return new OrderManager(this);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(ShoppingCartId)}={{{ShoppingCartId}}}");
            stringBuilder.AppendLine($"{nameof(ItemCount)}={{{ItemCount}}}");
            stringBuilder.AppendLine($"{nameof(User)}={{{User}}}");

            return stringBuilder.ToString();
        }
    }
}

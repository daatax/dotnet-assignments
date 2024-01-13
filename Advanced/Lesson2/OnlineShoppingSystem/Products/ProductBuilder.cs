using OnlineShoppingSystem.Helpers;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Products
{
    public class ProductBuilder
    {
        private ImmutableProductContext immutableProductContext = new ImmutableProductContext();

        public ProductBuilder()
        {
            immutableProductContext.ProductID = Utils.GenerateID();
            immutableProductContext.CategoryID = Utils.GenerateID();
            immutableProductContext.CreatedAt = DateTime.UtcNow;
            immutableProductContext.ProductStatus = ProductExecutionStatus.NotAvailable;
        }

        public ProductBuilder SetProductTitle(string productTitle)
        {
            if (string.IsNullOrEmpty(productTitle)) {
                throw new ArgumentNullException($"'{nameof(productTitle)}' cannot be null or empty.");
            }
            immutableProductContext.ProductTitle = productTitle;
            return this;
        }

        public ProductBuilder SetProductDescription(string productDescription)
        {
            if (string.IsNullOrEmpty(productDescription)) {
                throw new ArgumentNullException($"'{nameof(productDescription)}' cannot be null or empty.");
            }
            immutableProductContext.ProductDescription = productDescription;
            return this;
        }

        public ProductBuilder SetPrice(double price)
        {
            if (price < 0.0) {
                throw new ArgumentException($"'{nameof(price)}' cannot be negative.");
            }
            immutableProductContext.Price = price;
            return this;
        }

        public ProductBuilder SetTotalQuantity(int totalQuantity)
        {
            if (totalQuantity <= 0) {
                throw new ArgumentException($"'{nameof(totalQuantity)}' cannot be negative or 0.");
            }
            immutableProductContext.TotalQuantity = totalQuantity;
            return this;
        }

        public ProductBuilder SetMinQuantityPerOrder(int minQuantityPerOrder)
        {
            if (minQuantityPerOrder < 1) {
                throw new ArgumentException($"'{nameof(minQuantityPerOrder)}' cannot be less than 1.");
            }
            immutableProductContext.MinQuantityPerOrder = minQuantityPerOrder;
            return this;
        }

        public ProductBuilder SetMaxQuantityPerOrder(int maxQuantityPerOrder)
        {
            if (maxQuantityPerOrder < immutableProductContext.TotalQuantity) {
                throw new ArgumentException($"'{nameof(maxQuantityPerOrder)}' cannot be more than the {nameof(immutableProductContext.TotalQuantity)}.");
            }
            immutableProductContext.MaxQuantityPerOrder = maxQuantityPerOrder;
            return this;
        }

        public ProductManager Build()
        {
            Utils.ValidateRequiredFields(immutableProductContext.requiredFields, immutableProductContext);
            return new ProductManager(immutableProductContext);
        }
    }
}
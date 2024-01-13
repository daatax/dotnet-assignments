using System.Text;

#pragma warning disable CS8618
namespace OnlineShoppingSystem.Products
{
    public class ProductManager
    {
        private ImmutableProductContext immutableProductContext;

        public string ProductID => immutableProductContext.ProductID;
        public string CategoryID => immutableProductContext.CategoryID;
        public DateTime? CreatedAt => immutableProductContext.CreatedAt;
        public string ProductTitle => immutableProductContext.ProductTitle;
        public string ProductDescription => immutableProductContext.ProductDescription;
        public double Price => immutableProductContext.Price;
        public int TotalQuantity => immutableProductContext.TotalQuantity;
        public int MinQuantityPerOrder => immutableProductContext.MinQuantityPerOrder;
        public int MaxQuantityPerOrder => immutableProductContext.MaxQuantityPerOrder;
        public double ProductRate => immutableProductContext.ProductRate;
        public int ReviewCount => immutableProductContext.ReviewCount;
        public int OrderCount => immutableProductContext.OrderCount;
        public ProductExecutionStatus ProductStatus => immutableProductContext.ProductStatus;

        public ProductManager(ImmutableProductContext immutableProductContext)
        {
            this.immutableProductContext = immutableProductContext;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{nameof(ProductID)}={{{ProductID}}}");
            stringBuilder.AppendLine($"{nameof(CategoryID)}={{{CategoryID}}}");
            stringBuilder.AppendLine($"{nameof(CreatedAt)}={{{CreatedAt}}}");
            stringBuilder.AppendLine($"{nameof(ProductTitle)}={{{ProductTitle}}}");
            stringBuilder.AppendLine($"{nameof(ProductDescription)}={{{ProductDescription}}}");
            stringBuilder.AppendLine($"{nameof(Price)}={{{Price}}}");
            stringBuilder.AppendLine($"{nameof(TotalQuantity)}={{{TotalQuantity}}}");
            stringBuilder.AppendLine($"{nameof(MinQuantityPerOrder)}={{{MinQuantityPerOrder}}}");
            stringBuilder.AppendLine($"{nameof(MaxQuantityPerOrder)}={{{MaxQuantityPerOrder}}}");
            stringBuilder.AppendLine($"{nameof(ProductRate)}={{{ProductRate}}}");
            stringBuilder.AppendLine($"{nameof(ReviewCount)}={{{ReviewCount}}}");
            stringBuilder.AppendLine($"{nameof(OrderCount)}={{{OrderCount}}}");
            stringBuilder.AppendLine($"{nameof(ProductStatus)}={{{ProductStatus}}}");

            return stringBuilder.ToString();
        }
    }

    public class ImmutableProductContext
    {
        public string ProductID { get; set; }
        public string CategoryID { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int TotalQuantity { get; set; }
        public int MinQuantityPerOrder { get; set; }
        public int MaxQuantityPerOrder { get; set; }
        public double ProductRate { get; set; }
        public int ReviewCount { get; set; }
        public int OrderCount { get; set; }
        public ProductExecutionStatus ProductStatus { get; set; }

        public List<string> requiredFields = new List<string> {
            "ProductTitle", "ProductDescription", "Price", "TotalQuantity", "MinQuantityPerOrder"
        };
    }

    public enum ProductExecutionStatus
    {
        Available,
        NotAvailable,
    }
}

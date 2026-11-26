namespace ProductAgent.Domain.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public string BrandName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string ImageName { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}

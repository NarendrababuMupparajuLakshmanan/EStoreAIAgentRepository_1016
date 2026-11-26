namespace ProductAgent.Domain.DTOs
{
    public record ProductDTO(
        Guid Id,
        string ProductName,
        string ProductDescription,
        string BrandName,
        string Category,
        string ImageName,
        string ImageURL,
        decimal Price,
        int Quantity);
}

namespace ProductAgent.Domain.DTOs
{
    public record ProductDTO(
        Guid Id,
        string ProductName,
        string Category,
        decimal Price,
        int Quantity);
}

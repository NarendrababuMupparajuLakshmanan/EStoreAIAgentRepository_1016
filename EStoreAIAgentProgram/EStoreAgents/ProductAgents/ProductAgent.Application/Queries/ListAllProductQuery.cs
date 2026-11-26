using MediatR;
using ProductAgent.Domain.DTOs;

namespace ProductAgent.Application.Queries
{
    public record ListAllProductQuery()
        : IRequest<IReadOnlyList<ProductDTO>>
    {
    }
}

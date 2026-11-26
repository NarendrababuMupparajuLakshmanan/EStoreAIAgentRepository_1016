using MediatR;
using ProductAgent.Domain.DTOs;

namespace ProductAgent.Application.Queries
{
    public record GetProductByIdQuery(Guid Id)
        : IRequest<ProductDTO>
    {
    }
}

using MediatR;
using ProductAgent.Application.Mappers;
using ProductAgent.Application.Queries;
using ProductAgent.Domain.DTOs;
using ProductAgent.Domain.Models;
using ProductAgent.Domain.Repositories;

namespace ProductAgent.Application.Handlers
{
    public class GetProductByIdQueryHandler
        : IRequestHandler<GetProductByIdQuery, ProductDTO>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<ProductDTO> Handle(GetProductByIdQuery request, 
            CancellationToken cancellationToken)
        {
            ProductModel? productModel
                = await this._productRepository
                    .GetProductByIdAsync(request.Id, cancellationToken);

            return productModel.ToMapProduct();
        }
    }
}

using MediatR;
using ProductAgent.Application.Mappers;
using ProductAgent.Application.Queries;
using ProductAgent.Domain.DTOs;
using ProductAgent.Domain.Models;
using ProductAgent.Domain.Repositories;

namespace ProductAgent.Application.Handlers
{
    public class ListAllProductQueryHandler
        : IRequestHandler<ListAllProductQuery, IReadOnlyList<ProductDTO>>
    {
        /// <summary>
        /// Create a productRepository Object in a readonly Mode
        /// we dont change the instance of the Repository
        /// </summary>
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Constructor Dependecies Injection
        /// </summary>
        /// <param name="productRepository"></param>
        public ListAllProductQueryHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }


        public async Task<IReadOnlyList<ProductDTO>> Handle
            (ListAllProductQuery request, CancellationToken cancellationToken)
        {

            List<ProductModel> productModels
                = await this._productRepository.GetProductsAsync(cancellationToken);


            return productModels.ToMapProducts();
            
        }
    }
}

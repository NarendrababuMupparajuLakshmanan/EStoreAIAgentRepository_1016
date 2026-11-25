using MediatR;
using ProductAgent.Application.Mappers;
using ProductAgent.Application.Queries;
using ProductAgent.Domain.DTOs;
using ProductAgent.Domain.Models;
using ProductAgent.Infrastructure;

namespace ProductAgent.Application.Handlers
{
    public class ListAllProductQueryHandler
        : IRequestHandler<ListAllProductQuery, List<ProductDTO>>
    {
        /// <summary>
        /// Create a productRepository Object in a readonly Mode
        /// we dont change the instance of the Repository
        /// </summary>
        private readonly ProductRepository _productRepository;

        /// <summary>
        /// Constructor Dependecies Injection
        /// </summary>
        /// <param name="productRepository"></param>
        public ListAllProductQueryHandler(ProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }


        public async Task<List<ProductDTO>> Handle
            (ListAllProductQuery request, CancellationToken cancellationToken)
        {

            List<ProductModel> productModels
                = this._productRepository.Products.ToList();


            return productModels.ToMapProducts();
            
        }
    }
}

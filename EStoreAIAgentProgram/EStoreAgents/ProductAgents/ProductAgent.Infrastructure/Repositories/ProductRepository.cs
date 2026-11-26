using Microsoft.EntityFrameworkCore;
using ProductAgent.Domain.Models;
using ProductAgent.Domain.Repositories;

namespace ProductAgent.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EStoreDBContext _eStoreDBContext;

        public ProductRepository(EStoreDBContext eStoreDBContext)
        {
            this._eStoreDBContext = eStoreDBContext;
        }

        public async Task<ProductModel> GetProductByIdAsync(Guid Id, 
            CancellationToken cancellationToken)
        {
            ProductModel? productModel
                = await this._eStoreDBContext.Products
                    .FirstOrDefaultAsync(e => e.Id == Id, cancellationToken);

            if (productModel == null)
                throw new Exception("Product is not available for a given product ID");

            return productModel;
        }

        public async Task<List<ProductModel>> GetProductsAsync(CancellationToken cancellationToken)
        {
            List<ProductModel> productModels
                = await this._eStoreDBContext.Products.ToListAsync(cancellationToken);

            return productModels;
        }
    }
}

using ProductAgent.Domain.Models;

namespace ProductAgent.Domain.Repositories
{
    public interface IProductRepository
    {

        Task<List<ProductModel>> 
            GetProductsAsync(CancellationToken cancellationToken = default);

        Task<ProductModel>
            GetProductByIdAsync(Guid Id, CancellationToken cancellationToken);
    }
}

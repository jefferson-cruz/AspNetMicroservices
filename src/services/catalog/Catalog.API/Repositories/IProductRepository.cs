using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProduct(string id);

        Task<IEnumerable<Product>> GetProductsByName(string productName);

        Task<IEnumerable<Product>> GetProductsByCategory(string categoryName);

        Task Create(Product product);

        Task<bool> Update(Product product);

        Task<bool> Delete(string id);
    }
}

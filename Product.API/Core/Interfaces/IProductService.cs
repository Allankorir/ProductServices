using Product.API.Core.Entities;

namespace Product.API.Core.Interfaces
{
    public interface IProductService
    {
        Task<Productt> CreateProduct(Productt product);
        Task<List<Productt>> GetProduct();
        Task<Productt?> GetProductById(long id);
        Task<Productt?> UpdateProduct(long id,Productt productt);
        Task<Productt?> DeleteProduct(long id);


    }
}

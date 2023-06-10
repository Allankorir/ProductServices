using Microsoft.EntityFrameworkCore;
using Product.API.Core.Entities;
using Product.API.Core.Interfaces;
using Product.API.Infrastructure.Data;

namespace Product.API.Infrastructure.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }
        public async Task<Productt> CreateProduct(Productt product)
        {
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Productt?> DeleteProduct(long id)
        {
            var productToDelete= _context.Products.FirstOrDefault(x=> x.Id == id);

            if (productToDelete == null)
            {
                return null;
            }

             _context.Products.Remove(productToDelete);

            _context.SaveChanges();

            return productToDelete;
        }

        public async Task<List<Productt>> GetProduct()
        {
          return await _context.Products.ToListAsync();
        }

        public async Task<Productt?> GetProductById(long id)
        {
            var existinProduct =   _context.Products.FirstOrDefault(x => x.Id == id);

            if (existinProduct == null)
            {
                return null;
            }

            return existinProduct;
        }

        public async Task<Productt?> UpdateProduct(long id, Productt productt)
        {

            var productUpdate = _context.Products.FirstOrDefault(x => x.Id == id);

            if (productUpdate == null)
            {
                return null;
            }

            productUpdate.Name = productt.Name;

            productUpdate.Price = productt.Price;

            productUpdate.Description = productt.Description;

            _context.SaveChangesAsync();    

            return productUpdate;
        }
    }
}

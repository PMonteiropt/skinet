using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Product> getProductByIdAsync(int id)
        {
            return await _context.Products
            .Include(p => p.ProductType)
             .Include(p => p.ProductBrand)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Product>> getProductsAsync()
        {
             return await _context.Products
             .Include(p => p.ProductType)
             .Include(p => p.ProductBrand)
             .ToListAsync();
        }
    }
}
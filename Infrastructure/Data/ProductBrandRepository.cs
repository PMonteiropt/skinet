using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductBrandRepository : IProductBrandRepository
    {
        private readonly StoreContext _context;
        public ProductBrandRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<ProductBrand> getProductBrandByIdAsync(int id)
        {
            return await _context.ProductBrands.FindAsync(id);
        }

        public async Task<IReadOnlyList<ProductBrand>> getProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
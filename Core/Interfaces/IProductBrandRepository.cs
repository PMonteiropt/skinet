using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductBrandRepository
    {
       Task<ProductBrand> getProductBrandByIdAsync(int id);

        Task<IReadOnlyList<ProductBrand>> getProductBrandsAsync();  
    }
}
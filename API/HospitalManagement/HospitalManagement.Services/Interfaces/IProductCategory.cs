using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Domain.Models;

namespace HospitalManagement.Services.Interfaces
{
    public interface IProductCategoryService
    {
        Task<bool> CreateProductCategory(ProductCategory productCategory);

        Task<IEnumerable<ProductCategory>> GetAllProductCategory();

        Task<ProductCategory> GetProductCategoryById(int productId);

        Task<bool> UpdateProductCategorty(ProductCategory productCategory);

        Task<bool> DeleteProductCategory(int productId);
    }
}

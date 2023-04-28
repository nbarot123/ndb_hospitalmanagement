using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Core.Interfaces;
using HospitalManagement.Domain.Models;
using HospitalManagement.Services.Interfaces;

namespace HospitalManagement.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        public IUnitOfWork _unitOfWork;

        public ProductCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CreateProductCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductCategory(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductCategory>> GetAllProductCategory()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetProductCategoryById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductCategorty(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}

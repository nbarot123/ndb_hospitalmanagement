using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Core;
using HospitalManagement.Core.Interfaces;
using HospitalManagement.Domain.Models;
using HospitalManagement.Services.Interfaces;

namespace HospitalManagement.Services
{
    public class ProductService : IProductService
    {
        public IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CreateProduct(Products productDetails)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Products>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Products productDetails)
        {
            throw new NotImplementedException();
        }
    }
}

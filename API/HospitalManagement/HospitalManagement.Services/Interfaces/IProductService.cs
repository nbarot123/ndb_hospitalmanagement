using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Domain.Models;

namespace HospitalManagement.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProduct(Products productDetails);

        Task<IEnumerable<Products>> GetAllProducts();

        Task<Products> GetProductById(int productId);

        Task<bool> UpdateProduct(Products productDetails);

        Task<bool> DeleteProduct(int productId);
    }
}

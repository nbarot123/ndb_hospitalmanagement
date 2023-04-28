using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Domain.Models;

namespace HospitalManagement.Services.Interfaces
{
    public interface IDoctorCategoryService
    {
        Task<bool> CreateProductCategory(DoctorCategory productCategory);

        Task<IEnumerable<DoctorCategory>> GetAllProductCategory();

        Task<DoctorCategory> GetProductCategoryById(int productId);

        Task<bool> UpdateProductCategorty(DoctorCategory productCategory);

        Task<bool> DeleteProductCategory(int productId);
    }
}

using HospitalManagement.Core.Interfaces;
using HospitalManagement.Domain.Models;
using HospitalManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Services
{
    public class DoctorCategoryService : IDoctorCategoryService
    {
        public IUnitOfWork _unitOfWork;

        public DoctorCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<bool> CreateProductCategory(DoctorCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductCategory(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorCategory>> GetAllProductCategory()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorCategory> GetProductCategoryById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProductCategorty(DoctorCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}

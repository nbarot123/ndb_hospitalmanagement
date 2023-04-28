using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Domain.Models;
using HospitalManagement.Core.Interfaces;

namespace HospitalManagement.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(HospitalDBContext dbContext) : base(dbContext)
        {
        }        
    }
}

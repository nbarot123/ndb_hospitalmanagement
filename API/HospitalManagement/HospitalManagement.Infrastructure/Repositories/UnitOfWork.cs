using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Core;
using HospitalManagement.Core.Interfaces;

namespace HospitalManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalDBContext _dbContext;
        public IProductRepository ProductRepository { get; }

        public UnitOfWork(HospitalDBContext hospitalDBContext,
                          IProductRepository productRepository)
        {
            _dbContext = hospitalDBContext;
            ProductRepository = productRepository;
        }
        public void CreateTransaction()
            => _dbContext.Database.BeginTransaction();

        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Database.RollbackTransaction();

        public async Task RollbackAsync()
            => await _dbContext.Database.RollbackTransactionAsync();
    }
}

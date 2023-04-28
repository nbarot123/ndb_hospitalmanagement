using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HospitalManagement.Core.Interfaces
{
    public interface IUnitOfWork
    {        
        void CreateTransaction();                
        void Commit();                
        void Rollback();               
        Task CommitAsync();
        Task RollbackAsync();
        IProductRepository ProductRepository { get; }        
    }
}

using HospitalManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Infrastructure
{
    public class HospitalDBContext : DbContext
    {
        public HospitalDBContext(DbContextOptions<HospitalDBContext> contextOptions) : base(contextOptions)
        {
        }
        public DbSet<Products> TblProduct { get; set; }
        public DbSet<ProductCategory> TblProductCategory { get; set; }
        public DbSet<DoctorCategory> TblDoctorCategory { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

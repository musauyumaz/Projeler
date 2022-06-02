using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class DataTrackingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DataTrackingDb.mssql.somee.com ;Database = DataTrackingDb ; user = dataTracking_SQLLogin_2; password = e1g7cqijyj");
        }

        public DbSet<Data> Data { get; set; }
        public DbSet<Machine> Machines { get; set; }
    }
}

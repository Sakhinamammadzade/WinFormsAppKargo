using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CargoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CargoDb;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Package> Packages{get;set;} //sol terefdeki packages sqldeki table adidi
        public DbSet<Country> Countries { get; set; }  
    }
}


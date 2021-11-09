using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Entity;
using Microsoft.EntityFrameworkCore;


namespace backend.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<KullanıcıBilgi> KullanıcıBilgis { get; set; }
        public DbSet<Police> Polices { get; set; }


     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}


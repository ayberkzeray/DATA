using DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<IletisimBilgisi> IletisimBilgileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q3NBEGU;Database=PersonelOtomasyon;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonelMapping().Configure(modelBuilder.Entity<Personel>());
            new IletisimBilgisiMappping().Configure(modelBuilder.Entity<IletisimBilgisi>());

            base.OnModelCreating(modelBuilder);
        }
    }
}

using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            // Veritabanı bağlantısı
            Database.Connection.ConnectionString = "Server=OGRETMEN\\MSSQLSERVER01;Database=RentACar;uid=sa;password=1";
        }

        // Migration adımları 
        // enable-migrations
        // add-migration migration_adi
        // update-database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // Database tablolarını temsil eden DbSet'ler
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
    }
}

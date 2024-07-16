using DOO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Dao
{
    public class DatabaseDbContext : DbContext
    {
        private static string _dbFileName = "productos.db";

        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: @$"Filename={_dbFileName}", sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Producto>().HasKey(p => p.Id);
            modelBuilder.Entity<Producto>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Producto>().Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Producto>().Property(p => p.Precio).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}

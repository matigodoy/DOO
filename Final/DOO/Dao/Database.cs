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
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Barrio> Barrios { get; set; }

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

            modelBuilder.Entity<Persona>().ToTable("Personas");
            modelBuilder.Entity<Persona>().HasKey(p => p.Id);
            modelBuilder.Entity<Persona>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Persona>().Property(p => p.Nombre).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Apellido).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Documento).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.TipoDocumento).IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Telefono).IsRequired();
            modelBuilder.Entity<Persona>().HasOne(p => p.Direccion)
                                           .WithMany()
                                           .HasForeignKey(p => p.DireccionId)
                                           .IsRequired();

            modelBuilder.Entity<Direccion>().ToTable("Direcciones");
            modelBuilder.Entity<Direccion>().HasKey(d => d.Id);
            modelBuilder.Entity<Direccion>().Property(d => d.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Direccion>().Property(d => d.Calle).IsRequired();
            modelBuilder.Entity<Direccion>().HasOne(d => d.Barrio)
                                            .WithMany(b => b.Direcciones)
                                            .HasForeignKey(d => d.BarrioId)
                                            .IsRequired();

            modelBuilder.Entity<Barrio>().ToTable("Barrios");
            modelBuilder.Entity<Barrio>().HasKey(b => b.Id); // Asegurarse de que Barrio tenga una clave primaria
            modelBuilder.Entity<Barrio>().Property(b => b.Id).ValueGeneratedOnAdd(); // Agregar esta línea si falta
            modelBuilder.Entity<Barrio>().Property(b => b.Nombre).IsRequired();
            modelBuilder.Entity<Barrio>().Property(b => b.Zona).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}

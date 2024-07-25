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
    /*
   @startuml Clases

class Cliente{
  -pedido : Pedido
  -razonSocial:String
  -direccion:String
}

class Persona{
  -tipoDocumento:String
  -numeroDocumento:String
  -nombre:String
  -apellido:String
  -telefono:String
  -direccion:Direccion
}

class Empleado{
  -cargo:String
  -salario:Double
  -distribuidores:ArrayList<Distribuidor>
}

class Distribuidor extends Empleado {
  -zona:Zona
}

class Direccion{
  -barrio:Barrio
  -direccion:String
}

class Barrio{
  -nombre:String
  -zona:Zona
  -direcciones:ArrayList<Direccion>
}

class Zona{
  -nombre:String
  -barrios:ArrayList<Barrio>
}

class Pedido{
  -cliente:Cliente
  -detalles:ArrayList<DetallePedido>
  -fecha:String
  -total:Double
  -estado:String
  -fechaHoraEntregaEstimada:String
  -fechaHoraEntregaReal:String
  +posponerPedido(fecha:String)
}

class DetallePedido{
  -pedido:Pedido
  -producto:Producto
  -cantidad:Integer
  -preciounitario:Double
}

class Producto{
  -nombre:String
  -precio:Double
  +actualizarPrecio()
}

class Factura{
  -pedido:Pedido
  -empleado:Empleado
  -cliente:Cliente
  -fecha:String
  -total:Double
  +registrarFactura()
}

class DetalleFactura{
  -factura:Factura
  -producto:Producto
  -cantidad:Integer
  -preciounitario:Double
}

class CancelacionPedido{
  -pedido:Pedido
  -empleado:Empleado
  -fecha:String
  -motivo:String
}

abstract class FormaPago {
  -monto:Double
}

class Efectivo extends FormaPago {
}

class Cheque extends FormaPago {
  -numeroCheque:String
}

class Tarjeta extends FormaPago {
  -numeroTarjeta:String
  -nombreTarjeta:String
}

Persona <|-- Empleado
Empleado o-- Distribuidor
Persona <|-- Cliente
Barrio *-- Direccion
Zona *-- Barrio
Direccion <-- Persona
Pedido --> Cliente
DetallePedido o-- Producto
Factura --> Pedido
Factura --> Empleado
Factura --> Cliente
DetalleFactura *-- Factura
DetallePedido *-- Pedido
DetalleFactura o-- Producto
CancelacionPedido --> Pedido
CancelacionPedido --> Empleado
Factura --> FormaPago
@enduml

   */
    public class DatabaseDbContext : DbContext
    {
        private static string _dbFileName = "productos.db";

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Barrio> Barrios { get; set; }

        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<DetallePedido> DetallesPedido { get; set; }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Factura> Facturas { get; set; }
        //public DbSet<DetalleFactura> DetallesFactura { get; set; }
        //public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Zona> Zonas { get; set; }

        public DatabaseDbContext()
        {
            Database.EnsureCreated();
        }

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

            modelBuilder.Entity<Zona>().ToTable("Zona");
            modelBuilder.Entity<Zona>().HasKey(d => d.Id);
            modelBuilder.Entity<Zona>().Property(d => d.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Zona>().Property(b => b.Nombre).IsRequired();

            //modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            //modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            //modelBuilder.Entity<Pedido>().Property(p => p.Id).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Pedido>().Property(p => p.Fecha).IsRequired();
            //modelBuilder.Entity<Pedido>().Property(p => p.Total).IsRequired();
            //modelBuilder.Entity<Pedido>().Property(p => p.Estado).IsRequired();
            //modelBuilder.Entity<Pedido>().Property(p => p.FechaHoraEntregaEstimada).IsRequired();
            //modelBuilder.Entity<Pedido>().Property(p => p.FechaHoraEntregaReal).IsRequired();
            //modelBuilder.Entity<Pedido>().HasOne(p => p.Cliente)
            //                            .WithMany()
            //                            .HasForeignKey(p => p.ClienteId)
            //                            .IsRequired();

            //modelBuilder.Entity<DetallePedido>().ToTable("DetallesPedido");
            //modelBuilder.Entity<DetallePedido>().HasKey(d => d.);
            //modelBuilder.Entity<DetallePedido>().Property(d => d.Id).ValueGeneratedOnAdd();

           
            base.OnModelCreating(modelBuilder);
        }
    }
}

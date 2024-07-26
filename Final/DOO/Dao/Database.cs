using DOO.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Distribuidor> Distribuidores { get; set; }

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
            modelBuilder.Entity<Barrio>().HasMany(b => b.Direcciones)
                                        .WithOne()
                                        .IsRequired();

            modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Pedido>().Property(p => p.Fecha).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.Total).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.Estado).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.FechaHoraEntregaEstimada).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.FechaHoraEntregaReal).IsRequired();
            modelBuilder.Entity<Pedido>().HasOne(p => p.Cliente)
                             .WithMany()
                             .HasForeignKey(p => p.ClienteId)
                             .IsRequired();
            modelBuilder.Entity<Pedido>().HasMany(p => p.Detalles)
                                .WithOne()
                                .IsRequired();


            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Cliente>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Cliente>().Property(c => c.RazonSocial).IsRequired();
            modelBuilder.Entity<Cliente>().Property(c => c.Direccion).IsRequired();

            modelBuilder.Entity<Factura>().ToTable("Facturas");
            modelBuilder.Entity<Factura>().HasKey(f => f.Id);
            modelBuilder.Entity<Factura>().Property(f => f.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Factura>().Property(f => f.Fecha).IsRequired();
            modelBuilder.Entity<Factura>().Property(f => f.Total).IsRequired();
            modelBuilder.Entity<Factura>().HasOne(f => f.Pedido)
                                        .WithMany()
                                        .HasForeignKey(f => f.PedidoId)
                                        .IsRequired();
            modelBuilder.Entity<Factura>().HasOne(f => f.Empleado)
                .WithMany()
                                        .HasForeignKey(f => f.EmpleadoId)
                                        .IsRequired();
            modelBuilder.Entity<Factura>().HasOne(f => f.Cliente)
                .WithMany()
                                        .HasForeignKey(f => f.ClienteId)
                                        .IsRequired();
            modelBuilder.Entity<Factura>().HasMany(f => f.Detalles)
                                        .WithOne()
                                        .IsRequired();

            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<Empleado>().HasKey(e => e.Id);
            modelBuilder.Entity<Empleado>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Empleado>().Property(e => e.Cargo).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Salario).IsRequired();
            modelBuilder.Entity<Empleado>().HasMany(e => e.Distribuidores)
                                          .WithOne()
                                          .IsRequired();

            modelBuilder.Entity<Zona>().ToTable("Zonas");
            modelBuilder.Entity<Zona>().HasKey(z => z.Id);
            modelBuilder.Entity<Zona>().Property(z => z.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Zona>().Property(z => z.Nombre).IsRequired();
            modelBuilder.Entity<Zona>().HasMany(z => z.Barrios)
                                    .WithOne()
                                    .IsRequired();

            modelBuilder.Entity<Distribuidor>().ToTable("Distribuidores");
            modelBuilder.Entity<Distribuidor>().HasKey(d => d.Id);
            modelBuilder.Entity<Distribuidor>().Property(d => d.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Distribuidor>().HasOne(d => d.Zona)
                                              .WithMany()
                                              .HasForeignKey(d => d.ZonaId)
                                              .IsRequired();
            modelBuilder.Entity<Distribuidor>().HasOne(d => d.Empleado)
                                              .WithMany()
                                              .HasForeignKey(d => d.EmpleadoId)
                                              .IsRequired();

            modelBuilder.Entity<DetalleFactura>()
                .HasOne(d => d.Factura)
                .WithMany(f => f.Detalles)
                .HasForeignKey(d => d.FacturaId);

            modelBuilder.Entity<DetallePedido>()
               .HasOne(d => d.Pedido)
               .WithMany(p => p.Detalles)
               .HasForeignKey(d => d.PedidoId)
               .OnDelete(DeleteBehavior.Cascade);





            base.OnModelCreating(modelBuilder);
        }
    }
}

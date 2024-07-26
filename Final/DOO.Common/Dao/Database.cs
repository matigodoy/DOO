using DOO.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DOO.Common.Dao
{
    public class DatabaseDbContext : DbContext
    {
        private static string _dbFileName = "productos.db";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Distribuidor> Distribuidores { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallesPedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFacturas { get; set; }
        public DbSet<CancelacionPedido> CancelacionesPedidos { get; set; }
        public DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<Efectivo> Efectivos { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }

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


            // Creación de datos de prueba
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { PersonaId = 13486, ClienteId = 2, RazonSocial = "Soluciones moviles SRL", Direccion = "Av. Patria 5000", TipoDocumento = "DNI", NumeroDocumento = "866", Nombre = "Matias", Apellido = "Godoy", Telefono = "3511234567", DireccionId = 1 },
                new Cliente { PersonaId = 20489, ClienteId = 1, RazonSocial = "Torneria Jorge SA", Direccion = "Donato Alvarez 202", TipoDocumento = "DNI", NumeroDocumento = "453466", Nombre = "Jesus", Apellido = "Oliveto", Telefono = "3511234567", DireccionId = 1 }
            );
            modelBuilder.Entity<Zona>().HasData(
                new Zona { ZonaId = 1, Nombre = "Zona Norte" },
                new Zona { ZonaId = 2, Nombre = "Zona Sur" }
            );
            modelBuilder.Entity<Barrio>().HasData(
                new Barrio { BarrioId = 1, Nombre = "Granja de Funes", ZonaId = 1 },
                new Barrio { BarrioId = 2, Nombre = "Arguello", ZonaId = 1 },
                new Barrio { BarrioId = 3, Nombre = "Docta", ZonaId = 2 }
            );
            modelBuilder.Entity<Direccion>().HasData(
                new Direccion { DireccionId = 1, BarrioId = 1, DireccionTexto = "Av. Los Granaderos 100" },
                new Direccion { DireccionId = 2, BarrioId = 2, DireccionTexto = "Av. Donato Alvarez 202" },
                new Direccion { DireccionId = 3, BarrioId = 3, DireccionTexto = "Av. Docta 500" },
                new Direccion { DireccionId = 5, BarrioId = 2, DireccionTexto = "Islas del atlantico sur 2991" }
            );
            modelBuilder.Entity<Persona>().HasData(
                new Persona { PersonaId = 1, TipoDocumento = "DNI", NumeroDocumento = "12345678", Nombre = "Juan", Apellido = "Perez", Telefono = "3511234567", DireccionId = 1 },
                new Persona { PersonaId = 2, TipoDocumento = "DNI", NumeroDocumento = "87654321", Nombre = "Maria", Apellido = "Gomez", Telefono = "3517654321", DireccionId = 2 },
                new Persona { PersonaId = 3, TipoDocumento = "DNI", NumeroDocumento = "12345678", Nombre = "Juan", Apellido = "Perez", Telefono = "3511234567", DireccionId = 3 }
            );
            modelBuilder.Entity<Empleado>().HasData(
                new Empleado { PersonaId = 3435, Cargo = "Vendedor", Salario = 50000, Nombre = "Federico", Apellido = "Marquez", NumeroDocumento = "23232", TipoDocumento = "DNI", Telefono = "3511234567" },
                new Empleado { PersonaId = 6334, Cargo = "Gerente", Salario = 100000, Nombre = "Juan Manuel", Apellido = "De Aragón", NumeroDocumento = "232", TipoDocumento = "Pasaporte boliviano", Telefono = "3511234567" }
            );
            modelBuilder.Entity<Distribuidor>().HasData(
                new Distribuidor { PersonaId = 32323, Cargo = "Vendedor", Salario = 50000, Apellido = "Martina", Nombre = "Jose", NumeroDocumento = "12321321", TipoDocumento = "asdasdas", Telefono = "3511234567", ZonaId = 2 },
                new Distribuidor { PersonaId = 234, Cargo = "Gerente", Salario = 100000, Nombre = "Lucas", Apellido = "Moyano", NumeroDocumento = "12321321", TipoDocumento = "asdasdas", Telefono = "3511234567", ZonaId = 1 }
            );
            modelBuilder.Entity<Producto>().HasData(
                new Producto { ProductoId = 1, Nombre = "Coca Cola 2.25L", Precio = 120.6 },
                new Producto { ProductoId = 2, Nombre = "Fernet 1L", Precio = 300.1 },
                new Producto { ProductoId = 3, Nombre = "Papas fritas 200g", Precio = 5023.53 },
                new Producto { ProductoId = 4, Nombre = "Cerveza 1L", Precio = 1020.4 },
                new Producto { ProductoId = 5, Nombre = "Vino 750ml", Precio = 2000.50 }
            );
            modelBuilder.Entity<Pedido>().HasData(
                new Pedido { PedidoId = 1, ClienteId = 1, Fecha = "2021-10-10", Total = 1000.0, Estado = "En preparación", FechaHoraEntregaEstimada = "2021-10-11", FechaHoraEntregaReal = "2021-10-11" },
                new Pedido { PedidoId = 2, ClienteId = 2, Fecha = "2021-10-10", Total = 2000.0, Estado = "En preparación", FechaHoraEntregaEstimada = "2021-10-11", FechaHoraEntregaReal = "2021-10-11" }
            );
            modelBuilder.Entity<DetallePedido>().HasData(
                new DetallePedido { DetallePedidoId = 1, PedidoId = 1, ProductoId = 1, Cantidad = 2, PrecioUnitario = 100.0 },
                new DetallePedido { DetallePedidoId = 2, PedidoId = 1, ProductoId = 2, Cantidad = 1, PrecioUnitario = 200.0 },
                new DetallePedido { DetallePedidoId = 3, PedidoId = 2, ProductoId = 3, Cantidad = 3, PrecioUnitario = 300.0 },
                new DetallePedido { DetallePedidoId = 4, PedidoId = 2, ProductoId = 4, Cantidad = 4, PrecioUnitario = 400.0 }
            );
            modelBuilder.Entity<Factura>().HasData(
                new Factura { FacturaId = 1, PedidoId = 1, EmpleadoId = 1, ClienteId = 1, Fecha = "2021-10-11", Total = 1000.0 },
                new Factura { FacturaId = 2, PedidoId = 2, EmpleadoId = 2, ClienteId = 2, Fecha = "2021-10-11", Total = 2000.0 }
            );
            modelBuilder.Entity<DetalleFactura>().HasData(
                new DetalleFactura { DetalleFacturaId = 1, FacturaId = 1, ProductoId = 1, Cantidad = 2, PrecioUnitario = 100.0 },
                new DetalleFactura { DetalleFacturaId = 2, FacturaId = 1, ProductoId = 2, Cantidad = 1, PrecioUnitario = 200.0 },
                new DetalleFactura { DetalleFacturaId = 3, FacturaId = 2, ProductoId = 3, Cantidad = 3, PrecioUnitario = 300.0 },
                new DetalleFactura { DetalleFacturaId = 4, FacturaId = 2, ProductoId = 4, Cantidad = 4, PrecioUnitario = 400.0 }
            );
            modelBuilder.Entity<CancelacionPedido>().HasData(
                new CancelacionPedido { CancelacionPedidoId = 1, PedidoId = 1, EmpleadoId = 1, Fecha = "2021-10-11", Motivo = "Cliente canceló el pedido" },
                new CancelacionPedido { CancelacionPedidoId = 2, PedidoId = 2, EmpleadoId = 2, Fecha = "2021-10-11", Motivo = "Cliente canceló el pedido" }
            );
            modelBuilder.Entity<Efectivo>().HasData(
                new Efectivo { FormaPagoId = 1, Monto = 1000.0 },
                new Efectivo { FormaPagoId = 2, Monto = 2000.0 }
            );
            modelBuilder.Entity<Cheque>().HasData(
                new Cheque { FormaPagoId = 3, Monto = 1000.0, NumeroCheque = "3000" },
                new Cheque { FormaPagoId = 4, Monto = 2000.0, NumeroCheque = "4000" },
                new Cheque { FormaPagoId = 5, Monto = 3000.0, NumeroCheque = "5000" }
                );
            modelBuilder.Entity<Tarjeta>().HasData(
                new Tarjeta { FormaPagoId = 6, Monto = 1000.0, NumeroTarjeta = "123456789", NombreTarjeta = "Juan Perez" },
                new Tarjeta { FormaPagoId = 7, Monto = 2000.0, NumeroTarjeta = "987654321", NombreTarjeta = "Maria Gomez" }
            );




            base.OnModelCreating(modelBuilder);
        }
    }
}

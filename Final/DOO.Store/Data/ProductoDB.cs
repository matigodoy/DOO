using DOO.Common.Dao;
using DOO.Models;
using DOO.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Store.Data
{
    public class ProductosStore : IProducto
    {

        private readonly IServiceScopeFactory scopeFactory;

        public ProductosStore(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Producto GetProducto(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Productos.Find(id);
            }
        }

        public Producto GetProducto(string nombre)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Productos.FirstOrDefault(p => p.Nombre == nombre);
            }
        }

        public List<Producto> GetProductos(string nombre = "", int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Productos.ToList();
            }
        }

        public int InsertProducto(Producto producto)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Productos.Add(producto);

                return db.SaveChanges();
            }
        }

        public int UpdateProducto(Producto producto)
        {
            using var scope = scopeFactory.CreateScope();

            var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();
            db.Productos.Update(producto);

            return db.SaveChanges();
        }

        public int DeleteProducto(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var producto = db.Productos.Find(id);

                if (producto == null)
                    throw new Exception("Producto no encontrado");

                db.Productos.Remove(producto);

                return db.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DOO.Common.Dao;
using DOO.Models;
using DOO.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DOO.Store.Data
{
    public class PedidoDB
    {
        private readonly IServiceScopeFactory scopeFactory;

        public PedidoDB(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public int InsertPedido(Pedido pedido)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Pedidos.Add(pedido);
                return db.SaveChanges();
            }
        }

        public int UpdatePedido(Pedido pedido)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Pedidos.Update(pedido);
                return db.SaveChanges();
            }
        }

        public int DeletePedido(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var Pedido = db.Pedidos.Find(id);
                if (Pedido == null)
                    throw new Exception("Pedido no encontrada");

                db.Pedidos.Remove(Pedido);
                return db.SaveChanges();
            }
        }

        public Pedido GetPedido(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Pedidos.FirstOrDefault(p => p.PedidoId == id);

            }
        }

        public List<Pedido> GetPedidos(string nombre = "", int pageSize = 10, int pageIndex = 1, string sortField = "Nombre", int sortOrder = -1)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var query = db.Pedidos.AsQueryable();

                if (!string.IsNullOrEmpty(nombre))
                {
                    query = query.Where(p => p.Cliente.Nombre.ToLower().Contains(nombre.ToLower()));
                }

                if (sortOrder == -1)
                {
                    query = query.OrderByDescending(p => EF.Property<object>(p, sortField));
                }
                else
                {
                    query = query.OrderBy(p => EF.Property<object>(p, sortField));
                }
                return query.ToList();
            }
        }

        public List<Pedido> GetPedidos()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Pedidos.ToList();
            }
        }
    }
}

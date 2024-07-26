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
    public class ClienteDB : ICliente
    {
        private readonly IServiceScopeFactory scopeFactory;

        public ClienteDB(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public List<Cliente> GetClientes(string nombre = "", int pageSize = 10, int pageIndex = 1, string sortField = "Nombre", int sortOrder = -1)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var query = db.Clientes.AsQueryable();

                if (!string.IsNullOrEmpty(nombre))
                    query = query.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()));

                if (sortOrder == -1)
                    query = query.OrderByDescending(c => EF.Property<object>(c, sortField));
                else
                    query = query.OrderBy(c => EF.Property<object>(c, sortField));

                return query.ToList();
            }
        }

        public List<Cliente> GetClientes()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Clientes.ToList();
            }
        }

        public Cliente GetCliente(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Clientes.FirstOrDefault(c => c.ClienteId == id);
            }
        }

        public int InsertCliente(Cliente cliente)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Clientes.Add(cliente);
                return db.SaveChanges();
            }
        }

        public int UpdateCliente(Cliente cliente)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Clientes.Update(cliente);
                return db.SaveChanges();
            }
        }

        public int DeleteCliente(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var cliente = db.Clientes.Find(id);
                if (cliente == null)
                    throw new Exception("Cliente no encontrado");

                db.Clientes.Remove(cliente);
                return db.SaveChanges();
            }
        }
    }
}

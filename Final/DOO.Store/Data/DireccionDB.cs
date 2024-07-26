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
    public class DireccionDB
    {
        private readonly IServiceScopeFactory scopeFactory;

        public DireccionDB(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Barrio GetBarrio(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Barrios.FirstOrDefault(p => p.BarrioId == id);

            }
        }

        public List<Barrio> GetBarrios()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Barrios.ToList();
            }
        }

        public Zona GetZona(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Zonas.FirstOrDefault(p => p.ZonaId == id);

            }
        }

        public List<Zona> GetZonas()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Zonas.ToList();
            }
        }

        public Direccion GetDireccion(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Direcciones.FirstOrDefault(p => p.DireccionId == id);

            }
        }
        public List<Direccion> GetDirecciones()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Direcciones.ToList();
            }
        }

        public int InsertDireccion(Direccion direccion)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Direcciones.Add(direccion);
                return db.SaveChanges();
            }
        }


    }
}

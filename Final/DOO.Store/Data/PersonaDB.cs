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
    public class PersonaDB : IPersona
    {
        private readonly IServiceScopeFactory scopeFactory;

        public PersonaDB(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public int InsertPersona(Persona persona)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Personas.Add(persona);
                return db.SaveChanges();
            }
        }

        public int UpdatePersona(Persona persona)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                db.Personas.Update(persona);
                return db.SaveChanges();
            }
        }

        public int DeletePersona(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var persona = db.Personas.Find(id);
                if (persona == null)
                    throw new Exception("Persona no encontrada");

                db.Personas.Remove(persona);
                return db.SaveChanges();
            }
        }

        public Persona GetPersona(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Personas.FirstOrDefault(p => p.PersonaId == id);

            }
        }

        public List<Persona> GetPersonas(string nombre = "", int pageSize = 10, int pageIndex = 1, string sortField = "Nombre", int sortOrder = -1)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                var query = db.Personas.AsQueryable();

                if (!string.IsNullOrEmpty(nombre))
                {
                    query = query.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()));
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

        public List<Persona> GetPersonas()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Personas.ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOO.Dao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace DOO.Models
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

                return db.Personas.Find(id);
            }
        }

        public List<Persona> GetPersonas(string nombre = "", int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseDbContext>();

                return db.Personas.ToList();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOO.Models;

namespace DOO.Store.Data
{
    internal interface IPersona
    {
        public int InsertPersona(Persona persona);

        public int UpdatePersona(Persona persona);
        public int DeletePersona(int id);
        public Persona GetPersona(int id);
        public List<Persona> GetPersonas(string nombre, int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1);
        public List<Persona> GetPersonas();

    }
}

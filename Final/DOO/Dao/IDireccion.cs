using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOO.Models;

namespace DOO.Dao
{
    internal interface IDireccion
    {
        public int InsertDireccion(Direccion direccion);
        public int UpdateDireccion(Direccion direccion);
        public int DeleteDireccion(int id);
        public Direccion GetDireccion(int id);
        public List<Direccion> GetDirecciones(string nombre, int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1);
        public List<Direccion> GetDirecciones();
    }
}

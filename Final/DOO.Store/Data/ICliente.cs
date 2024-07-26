using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOO.Models;

namespace DOO.Store.Data
{
    internal interface ICliente
    {
        public int InsertCliente(Cliente Cliente);
        public int UpdateCliente(Cliente Cliente);
        public int DeleteCliente(int id);
        public Cliente GetCliente(int id);
        public List<Cliente> GetClientes(string nombre, int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1);
        public List<Cliente> GetClientes();

    }
}

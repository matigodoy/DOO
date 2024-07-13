using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOO.Models;

namespace DOO.Dao
{
    public interface IProducto
    {
        Producto GetProducto(int id);

        Producto GetProducto(string nombre);

        List<Producto> GetProductos(string nombre, int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1);

        int InsertProducto(Producto producto);

        int UpdateProducto(Producto producto);

        int DeleteProducto(int id);
    }
}

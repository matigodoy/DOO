using DOO.Models;

namespace DOO.Dao
{
    public interface IProducto
    {
        public Producto GetProducto(int id);

        public Producto GetProducto(string nombre);

        public List<Producto> GetProductos(string nombre, int pageSize = 10, int pageIndex = 1, string sortField = "nombre", int sortOrder = -1);

        public int InsertProducto(Producto producto);

        public int UpdateProducto(Producto producto);

        public int DeleteProducto(int id);
    }
}

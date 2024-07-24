namespace DOO.Models
{
    public class Producto
    {
        #region Variables
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int Id { get; set; }

        #endregion

        #region Constructores


        public Producto()
        {
        }

        public Producto(int id, string nombre, double precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public int Precio { get; set; }

        #region Constructores

        public DetalleFactura() { }
        public DetalleFactura(Factura factura, Producto producto, int cantidad, double precioUnitario, int id)
        {
            Factura = factura;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Id = id;
        }
        #endregion
    }
}

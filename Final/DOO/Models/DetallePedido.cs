using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class DetallePedido
    {
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public DetallePedido(Pedido pedido, Producto producto, int cantidad, double precioUnitario)
        {
            Pedido = pedido;
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        public double CalcularSubtotal()
        {
            return Cantidad * PrecioUnitario;
        }

        public double CalcularTotal()
        {
            return CalcularSubtotal() * 1.21;
        }

        public override string ToString()
        {
            return $"{Producto.Nombre} x {Cantidad} = {CalcularSubtotal()}";
        }
    }
}

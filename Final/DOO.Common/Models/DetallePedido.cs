using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class DetallePedido
    {
        public int DetallePedidoId { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public DetallePedido()
        {

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

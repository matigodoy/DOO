using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class Factura
    {
        public Pedido Pedido { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public string Fecha { get; set; }
        public double Total { get; set; }

        public void registrarFactura()
        {
            if (Pedido == null)
            {
                throw new Exception("No se puede registrar una factura sin un pedido");
            }
            if (Empleado == null)
            {
                throw new Exception("No se puede registrar una factura sin un empleado");
            }
            if (Cliente == null)
            {
                throw new Exception("No se puede registrar una factura sin un cliente");
            }
            if (Fecha == null)
            {
                throw new Exception("No se puede registrar una factura sin una fecha");
            }
            if (Total == 0)
            {
                throw new Exception("No se puede registrar una factura sin un total");
            }
        }

        public Factura(Pedido pedido, Empleado empleado, Cliente cliente, string fecha, double total)
        {
            Pedido = pedido;
            Empleado = empleado;
            Cliente = cliente;
            Fecha = fecha;
            Total = total;
        }

        public Factura() { }

        public Factura(Pedido pedido, Empleado empleado, Cliente cliente, string fecha)
        {
            Pedido = pedido;
            Empleado = empleado;
            Cliente = cliente;
            Fecha = fecha;
        }

        public Factura(Pedido pedido, Empleado empleado, Cliente cliente)
        {
            Pedido = pedido;
            Empleado = empleado;
            Cliente = cliente;
        }
    }
}

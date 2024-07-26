using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public int PedidoId { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }
        public string Fecha { get; set; }
        public double Total { get; set; }

        public void registrarFactura()
        {
            if (FacturaId == 0)
            {
                throw new Exception("No se puede registrar una factura sin un id");
            }
            if (PedidoId == 0)
            {
                throw new Exception("No se puede registrar una factura sin un pedido");
            }
            if (EmpleadoId == 0)
            {
                throw new Exception("No se puede registrar una factura sin un empleado");
            }
            if (ClienteId == 0)
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

            Console.WriteLine("Factura registrada");
        }
    }
}

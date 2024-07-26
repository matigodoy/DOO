using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class CancelacionPedido
    {
        public int CancelacionPedidoId { get; set; }
        public int PedidoId { get; set; }
        public int EmpleadoId { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
    }
}

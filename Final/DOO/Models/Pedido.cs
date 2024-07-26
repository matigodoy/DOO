using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetallePedido> Detalles { get; set; }
        public string Fecha { get; set; }
        public double Total { get; set; }
        public string Estado { get; set; }
        public string FechaHoraEntregaEstimada { get; set; }
        public string FechaHoraEntregaReal { get; set; }

        public void posponerPedido(string fecha)
        {
            this.FechaHoraEntregaEstimada = fecha;
        }

        public Pedido(Cliente cliente, List<DetallePedido> detalles, string fecha, double total, string estado, string fechaHoraEntregaEstimada, string fechaHoraEntregaReal)
        {
            Cliente = cliente;
            Detalles = detalles;
            Fecha = fecha;
            Total = total;
            Estado = estado;
            FechaHoraEntregaEstimada = fechaHoraEntregaEstimada;
            FechaHoraEntregaReal = fechaHoraEntregaReal;
        }

        public Pedido()
        {
        }

        public Pedido(int id, Cliente cliente, List<DetallePedido> detalles, string fecha, double total, string estado, string fechaHoraEntregaEstimada, string fechaHoraEntregaReal)
        {
            Id = id;
            Cliente = cliente;
            Detalles = detalles;
            Fecha = fecha;
            Total = total;
            Estado = estado;
            FechaHoraEntregaEstimada = fechaHoraEntregaEstimada;
            FechaHoraEntregaReal = fechaHoraEntregaReal;
        }

        public Pedido(int id, Cliente cliente, string fecha, double total, string estado, string fechaHoraEntregaEstimada, string fechaHoraEntregaReal)
        {
            Id = id;
            Cliente = cliente;
            Fecha = fecha;
            Total = total;
            Estado = estado;
            FechaHoraEntregaEstimada = fechaHoraEntregaEstimada;
            FechaHoraEntregaReal = fechaHoraEntregaReal;
        }
    }
}

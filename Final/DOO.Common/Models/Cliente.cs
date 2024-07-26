using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}

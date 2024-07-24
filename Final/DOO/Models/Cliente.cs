using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    public class Cliente
    {
        public Pedido Pedido { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Cliente(Pedido pedido, string razonSocial, string direccion)
        {
            Pedido = pedido;
            RazonSocial = razonSocial;
            Direccion = direccion;
        }

        public Cliente() { }

        public Cliente(string razonSocial, string direccion)
        {
            RazonSocial = razonSocial;
            Direccion = direccion;
        }

        public Cliente(string razonSocial)
        {
            RazonSocial = razonSocial;
        }

        public Cliente(string razonSocial, string direccion, Pedido pedido)
        {
            RazonSocial = razonSocial;
            Direccion = direccion;
            Pedido = pedido;
        }

        public Cliente(string razonSocial, Pedido pedido)
        {
            RazonSocial = razonSocial;
            Pedido = pedido;
        }

        public Cliente(Pedido pedido)
        {
            Pedido = pedido;
        }
    }
}

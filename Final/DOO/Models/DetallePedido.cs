using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOO.Models
{
    /*
     @startuml Clases

class Cliente{
    -pedido : Pedido
    -razonSocial:String
    -direccion:String
}

class Persona{
    -tipoDocumento:String
    -numeroDocumento:String
    -nombre:String
    -apellido:String
    -telefono:String
    -direccion:Direccion
}

class Empleado{
    -cargo:String
    -salario:Double
    -distribuidores:ArrayList<Distribuidor>
}

class Distribuidor extends Empleado {
    -zona:Zona
}

class Direccion{
    -barrio:Barrio
    -direccion:String
}

class Barrio{
    -nombre:String
    -zona:Zona
    -direcciones:ArrayList<Direccion>
}

class Zona{
    -nombre:String
    -barrios:ArrayList<Barrio>
}

class Pedido{
    -cliente:Cliente
    -detalles:ArrayList<DetallePedido>
    -fecha:String
    -total:Double
    -estado:String
    -fechaHoraEntregaEstimada:String
    -fechaHoraEntregaReal:String
    +posponerPedido(fecha:String)
}

class DetallePedido{
    -pedido:Pedido
    -producto:Producto
    -cantidad:Integer
    -preciounitario:Double
}

class Producto{
    -nombre:String
    -precio:Double
    +actualizarPrecio()
}

class Factura{
    -pedido:Pedido
    -empleado:Empleado
    -cliente:Cliente
    -fecha:String
    -total:Double
    +registrarFactura()
}

class DetalleFactura{
    -factura:Factura
    -producto:Producto
    -cantidad:Integer
    -preciounitario:Double
}

class CancelacionPedido{
    -pedido:Pedido
    -empleado:Empleado
    -fecha:String
    -motivo:String
}

abstract class FormaPago {
    -monto:Double
}

class Efectivo extends FormaPago {
}

class Cheque extends FormaPago {
    -numeroCheque:String
}

class Tarjeta extends FormaPago {
    -numeroTarjeta:String
    -nombreTarjeta:String
}

Persona <|-- Empleado
Empleado o-- Distribuidor
Persona <|-- Cliente
Barrio *-- Direccion
Zona *-- Barrio
Direccion <-- Persona
Pedido --> Cliente
DetallePedido o-- Producto
Factura --> Pedido
Factura --> Empleado
Factura --> Cliente
DetalleFactura *-- Factura
DetallePedido *-- Pedido
DetalleFactura o-- Producto
CancelacionPedido --> Pedido
CancelacionPedido --> Empleado
Factura --> FormaPago
@enduml

     */

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

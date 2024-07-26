namespace DOO.Models;

public class Barrio
{
    public int BarrioId { get; set; }
    public int ZonaId { get; set; }
    public string Nombre { get; set; }
    public ICollection<Direccion> Direcciones { get; set; }

    public void AgregarDireccion(Direccion direccion)
    {
        Direcciones.Add(direccion);
    }

    public void EliminarDireccion(Direccion direccion)
    {
        Direcciones.Remove(direccion);
    }
}
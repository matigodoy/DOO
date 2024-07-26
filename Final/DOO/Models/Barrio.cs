namespace DOO.Models;

public class Barrio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public List<Direccion> Direcciones { get; set; }

    public Barrio()
    {
        Direcciones = new List<Direccion>();
    }

    public Barrio(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
        Direcciones = new List<Direccion>();
    }

    public void AgregarDireccion(Direccion direccion)
    {
        Direcciones.Add(direccion);
    }

    public void EliminarDireccion(Direccion direccion)
    {
        Direcciones.Remove(direccion);
    }
}
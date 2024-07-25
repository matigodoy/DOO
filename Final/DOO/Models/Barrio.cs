namespace DOO.Models;

public class Barrio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public Zona Zona { get; set; }
    public List<Direccion> Direcciones { get; set; }

    public Barrio()
    {
        Direcciones = new List<Direccion>();
    }

    public Barrio(int id, string nombre, Zona zona)
    {
        Id = id;
        Nombre = nombre;
        Zona = zona;
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

    public void ActualizarZona(Zona zona)
    {
        Zona = zona;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Zona}";
    }
}
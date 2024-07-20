namespace DOO.Models;

public class Barrio
{
    public string Nombre { get; set; }
    public Zona Zona { get; set; }
    public List<Direccion> Direcciones { get; set; }
}
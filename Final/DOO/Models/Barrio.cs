namespace DOO.Models;

public class Barrio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Zona { get; set; }
    public List<Direccion> Direcciones { get; set; }
}
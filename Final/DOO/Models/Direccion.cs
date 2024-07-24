namespace DOO.Models;

public class Direccion
{
    public int Id { get; set; }
    public Barrio Barrio { get; set; }
    public int BarrioId { get; set; }
    public string Calle { get; set; }
}
namespace DOO.Models;

public class Persona
{
    public int Id { get; set; }
    public string TipoDocumento { get; set; }
    public string Documento { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public Direccion Direccion { get; set; }
}
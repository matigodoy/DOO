namespace DOO.Models;

public class Persona
{
    public string tipoDocumento { get; set; }
    public string documento { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string telefono { get; set; }
    public Direccion Direccion { get; set; }
}
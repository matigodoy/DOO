using System.ComponentModel.DataAnnotations.Schema;

namespace DOO.Models;

public class Persona
{
    public int Id { get; set; }
    public int DireccionId { get; set; }
    public string TipoDocumento { get; set; }
    public string Documento { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }

    [ForeignKey("DireccionId")]
    public Direccion Direccion { get; set; }

    public override string ToString()
    {
        return $"{Nombre} {Apellido}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Persona)
        {
            Persona persona = (Persona)obj;
            return persona.TipoDocumento.Equals(TipoDocumento) && persona.Documento.Equals(Documento);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return TipoDocumento.GetHashCode();
    }

    public void ActualizarTipoDocumento(string tipoDocumento)
    {
        TipoDocumento = tipoDocumento;
    }

    public void ActualizarDocumento(string documento)
    {
        Documento = documento;
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace DOO.Models;

public class Persona
{
    public int PersonaId { get; set; }
    public int DireccionId { get; set; }
    public string TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }

    public override string ToString()
    {
        return $"{Nombre} {Apellido}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var p = (Persona)obj;
        return TipoDocumento == p.TipoDocumento;
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
        NumeroDocumento = documento;
    }
}
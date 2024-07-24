namespace DOO.Models;

public class Persona
{
    public int Id { get; set; }
    public string TipoDocumento { get; set; }
    public string Documento { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public int DireccionId { get; set; }
    public Direccion Direccion { get; set; }

    public Persona()
    {
    }

    public Persona(int id, string tipoDocumento, string documento, string nombre, string apellido, string telefono, int direccionId, Direccion direccion)
    {
        Id = id;
        TipoDocumento = tipoDocumento;
        Documento = documento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        DireccionId = direccionId;
        Direccion = direccion;
    }

    public Persona(string tipoDocumento, string documento, string nombre, string apellido, string telefono, int direccionId, Direccion direccion)
    {
        TipoDocumento = tipoDocumento;
        Documento = documento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        DireccionId = direccionId;
        Direccion = direccion;
    }

    public Persona(string tipoDocumento, string documento, string nombre, string apellido, string telefono, Direccion direccion)
    {
        TipoDocumento = tipoDocumento;
        Documento = documento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Direccion = direccion;
    }

    public Persona(string tipoDocumento, string documento, string nombre, string apellido, string telefono)
    {
        TipoDocumento = tipoDocumento;
        Documento = documento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
    }

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
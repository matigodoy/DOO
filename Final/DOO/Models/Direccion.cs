namespace DOO.Models;

public class Direccion
{
    public int DireccionId { get; set; }
    public int BarrioId { get; set; }
    public string DireccionTexto { get; set; }


    public override string ToString()
    {
        return $"{BarrioId} - {DireccionTexto}";
    }

    public override bool Equals(object obj)
    {
        return false;
    }

    public override int GetHashCode()
    {
        return 0;
    }

    public void ActualizarBarrio(Barrio barrio)
    {
        BarrioId = barrio.BarrioId;
    }

    public void ActualizarCalle(string calle)
    {
        DireccionTexto = calle;
    }
}
namespace DOO.Models;

public class Direccion
{
    public int Id { get; set; }
    public Barrio Barrio { get; set; }
    public int BarrioId { get; set; }
    public string Calle { get; set; }

    public Direccion(Barrio barrio, string calle)
    {
        Barrio = barrio;
        Calle = calle;
    }

    public Direccion() { }

    public Direccion(string calle)
    {
        Calle = calle;
    }

    public Direccion(Barrio barrio)
    {
        Barrio = barrio;
    }

    public override string ToString()
    {
        return $"{Barrio} - {Calle}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Direccion)
        {
            Direccion direccion = (Direccion)obj;
            return direccion.Barrio.Equals(Barrio) && direccion.Calle.Equals(Calle);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Barrio.GetHashCode();
    }

    public void ActualizarBarrio(Barrio barrio)
    {
        Barrio = barrio;
    }

    public void ActualizarCalle(string calle)
    {
        Calle = calle;
    }
}
namespace DOO.Models;

public class Zona
{
    public int ZonaId { get; set; }
    public string Nombre { get; set; }
    public ICollection<Barrio> Barrios { get; set; }


    public void AgregarBarrio(Barrio barrio)
    {
        Barrios.Add(barrio);
    }

    public void EliminarBarrio(Barrio barrio)
    {
        Barrios.Remove(barrio);
    }

    public override string ToString()
    {
        return $"{Nombre}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Zona)
        {
            Zona zona = (Zona)obj;
            return zona.Nombre.Equals(Nombre);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Nombre.GetHashCode();
    }
}
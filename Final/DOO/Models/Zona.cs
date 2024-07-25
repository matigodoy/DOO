namespace DOO.Models;

public class Zona
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public List<Barrio> Barrios { get; set; }

    public Zona()
    {
        Barrios = new List<Barrio>();
    }

    public Zona(string nombre)
    {
        Nombre = nombre;
        Barrios = new List<Barrio>();
    }

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
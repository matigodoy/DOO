namespace DOO.Models;
public class Empleado : Persona
{
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public ICollection<Distribuidor> Distribuidores { get; set; }


    public void AgregarDistribuidor(Distribuidor distribuidor)
    {
        Distribuidores.Add(distribuidor);
    }

    public void EliminarDistribuidor(Distribuidor distribuidor)
    {
        Distribuidores.Remove(distribuidor);
    }

    public void ActualizarSalario(double salario)
    {
        Salario = salario;
    }

    public override string ToString()
    {
        return $"{Cargo} - {Salario}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Empleado e = (Empleado)obj;
        return PersonaId == e.PersonaId;
    }

    public override int GetHashCode()
    {
        return PersonaId;
    }

    public void ActualizarCargo(string cargo)
    {
        Cargo = cargo;
    }

    public void ActualizarDistribuidores(List<Distribuidor> distribuidores)
    {
        Distribuidores = distribuidores;
    }

    public void ActualizarDistribuidores(Distribuidor distribuidor)
    {
        Distribuidores.Add(distribuidor);
    }

    public void ActualizarDistribuidores()
    {
        Distribuidores = new List<Distribuidor>();
    }
}
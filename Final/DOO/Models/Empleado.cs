namespace DOO.Models;
public class Empleado
{
    public int Id { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public List<Distribuidor> Distribuidores { get; set; }

    public Empleado()
    {
        Distribuidores = new List<Distribuidor>();
    }

    public Empleado(int id, string cargo, double salario)
    {
        Id = id;
        Cargo = cargo;
        Salario = salario;
        Distribuidores = new List<Distribuidor>();
    }

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
        if (obj is Empleado)
        {
            Empleado empleado = (Empleado)obj;
            return empleado.Id == Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Id;
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
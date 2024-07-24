namespace DOO.Models;

public class Empleado
{
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public List<Distribuidor> Distribuidores { get; set; }
}
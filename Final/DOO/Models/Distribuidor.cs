namespace DOO.Models;

public class Distribuidor
{
    public Empleado Empleado { get; set; }
    public Zona Zona { get; set; }

    public Distribuidor(Empleado empleado, Zona zona)
    {
        Empleado = empleado;
        Zona = zona;
    }

    public Distribuidor() { }

    public Distribuidor(Empleado empleado)
    {
        Empleado = empleado;
    }

    public Distribuidor(Zona zona)
    {
        Zona = zona;
    }

    public override string ToString()
    {
        return $"{Empleado} - {Zona}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Distribuidor)
        {
            Distribuidor distribuidor = (Distribuidor)obj;
            return distribuidor.Empleado.Equals(Empleado) && distribuidor.Zona.Equals(Zona);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Empleado.GetHashCode();
    }

    public void ActualizarZona(Zona zona)
    {
        Zona = zona;
    }

    public void ActualizarEmpleado(Empleado empleado)
    {
        Empleado = empleado;
    }

    public void ActualizarEmpleadoZona(Empleado empleado, Zona zona)
    {
        Empleado = empleado;
        Zona = zona;
    }
}
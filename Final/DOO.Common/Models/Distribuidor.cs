namespace DOO.Models;

public class Distribuidor : Empleado
{
    public int ZonaId { get; set; }


    public override string ToString()
    {
        return ZonaId.ToString();
    }

    public override bool Equals(object obj)
    {
        return false;
    }


    public override int GetHashCode()
    {
        return PersonaId;
    }

    public void ActualizarZona(Zona zona)
    {
        ZonaId = zona.ZonaId;
    }

    //public void ActualizarEmpleado(Empleado empleado)
    //{
    //    Zona = empleado.Zona;
    //}

    //public void ActualizarEmpleadoZona(Empleado empleado, Zona zona)
    //{
    //    Empleado = empleado;
    //    Zona = zona;
    //}
}
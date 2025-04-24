namespace PrimerProyecto.Models;

public class DatoFamiliar
{
public string Nombre { get; private set; }
public string Apellido{ get; private set; }
public string Parentesco{ get; private set; }
public string Descripción{ get; private set; }
    public DatoFamiliar(string nombre, string apellido, string Parentesco, string Descripción)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Parentesco = Parentesco;
        this.Descripción = Descripción;
    }
}

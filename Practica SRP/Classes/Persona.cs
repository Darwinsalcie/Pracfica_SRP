

namespace Practica_SRP.Class;

public class Persona
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public string? Direccion { get; set; }
    public string? CorreoElectronico { get; set; }


    public void ImprimirDatos()
    {

        Console.WriteLine($"Npmbre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Direccion: {CorreoElectronico}");
        Console.WriteLine($"Direeecion: {Direccion}");


    }

}

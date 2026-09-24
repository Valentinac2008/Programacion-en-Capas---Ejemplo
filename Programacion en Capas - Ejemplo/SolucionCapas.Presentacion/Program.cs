using System;
using SolucionCapas.Negocio; 

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese DNI: ");
        string dni = Console.ReadLine();

        PersonaNegocio negocio = new PersonaNegocio();

        // La Presentación recibe a Persona directamente desde Negocio
        Persona persona = negocio.ObtenerPersona(dni);

        if (persona != null)
            Console.WriteLine($"Encontrado: {persona.Nombre}");
        else
            Console.WriteLine("No existe.");
    }
}

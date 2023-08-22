using System;

class SaludoYHora
{
    static void Main()
    {
        Console.WriteLine("¡Hola! Bienvenido al programa de saludo y hora.");
        Console.Write("Por favor, ingresa tu nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine($"Hola, {nombre}.");
        MostrarHoraActual();

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void MostrarHoraActual()
    {
        DateTime horaActual = DateTime.Now;
        Console.WriteLine($"La hora actual es: {horaActual.ToShortTimeString()}");
    }
}

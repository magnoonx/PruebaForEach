using System;

class Program
{
    static void Main()
    {
        // Definir una lista de nombres
        string[] nombres = { "Juan", "María", "Pedro", "Luisa" };

        // Iterar sobre la lista de nombres usando foreach
        Console.WriteLine("Lista de nombres:");
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // Definir un diccionario de edades
        var edades = new Dictionary<string, int>
        {
            { "Juan", 30 },
            { "María", 25 },
            { "Pedro", 35 },
            { "Luisa", 28 }
        };

        // Iterar sobre el diccionario de edades usando foreach
        Console.WriteLine("\nDiccionario de edades:");
        foreach (var kvp in edades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} años");
        }
    }
}
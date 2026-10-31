class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("Estatura en metros (ej. 1.70): ");
        double estatura = double.Parse(Console.ReadLine()!);

        Console.Write("¿Trabaja? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine()!);

        int anioTreinta = ANIO_ACTUAL + (30 - edad);

        Console.WriteLine();
        Console.WriteLine("===== FICHA PERSONAL =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en el año {anioTreinta}");
    }
}
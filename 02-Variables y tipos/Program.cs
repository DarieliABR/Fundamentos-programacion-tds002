class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.Write("Nombre:  ");
        string nombre = Console.ReadLine()!;

        Console.Write("Edad:  ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("Estatura en metros (ej. 1.70):  ");
        double estatura = double.Parse(Console.ReadLine()!);

        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine($"Hola, {nombre}.");
        Console.WriteLine($"Tienes {edad} años y mides {estatura} m.");
        Console.WriteLine($"Naciste aproximadamente en el año {anioNacimiento}.");
    }
}

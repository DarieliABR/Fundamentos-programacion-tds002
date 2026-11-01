class Program
{
    static void Main(string[] args)
    {
        // Constante: equivalencia de una libra en kilogramos
        const double KG_POR_LIBRA = 0.453592;

        // ENTRADA
        Console.Write("Peso en libras (lb): ");
        double libras = double.Parse(Console.ReadLine()!);

        Console.Write("Temperatura en grados Fahrenheit (°F): ");
        double fahrenheit = double.Parse(Console.ReadLine()!);

        // PROCESO
        double kilogramos = libras * KG_POR_LIBRA;
        double celsius = (fahrenheit - 32) * 5 / 9;

        // SALIDA con 2 decimales
        Console.WriteLine();
        Console.WriteLine($"{libras:F2} lb equivalen a {kilogramos:F2} kg");
        Console.WriteLine($"{fahrenheit:F2} °F equivalen a {celsius:F2} °C");
    }
}
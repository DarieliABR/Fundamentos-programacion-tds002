class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escribe un número con decimales (ej. 7.85): ");
        double numeroDecimal = double.Parse(Console.ReadLine()!);

        int parteEntera = (int)numeroDecimal;

        double enteroComoDecimal = parteEntera;

        Console.WriteLine($"Número original: {numeroDecimal}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");
        Console.WriteLine($"Entero convertido a double (casting implícito): {enteroComoDecimal:F2}");
    }
}
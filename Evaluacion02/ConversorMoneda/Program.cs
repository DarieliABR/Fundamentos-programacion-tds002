class Program
{
    static void Main(string[] args)
    {
        const double TASA_USD = 60.73;

        Console.Write("Monto en pesos (RD$): ");
        double montoPesos = double.Parse(Console.ReadLine()!);

        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine($"Tasa del día: RD$ {TASA_USD} por US$ 1");
        Console.WriteLine($"RD$ {montoPesos:F2} equivalen a US$ {montoDolares:F2}");
    }
}
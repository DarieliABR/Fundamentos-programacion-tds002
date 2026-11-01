class Program
{
    static void Main(string[] args)
    {
        // ENTRADA
        Console.Write("Radio del círculo: ");
        double radio = double.Parse(Console.ReadLine()!);

        Console.Write("Cateto 1 del triángulo: ");
        double cateto1 = double.Parse(Console.ReadLine()!);

        Console.Write("Cateto 2 del triángulo: ");
        double cateto2 = double.Parse(Console.ReadLine()!);

        // PROCESO
        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

        // SALIDA con 2 decimales
        Console.WriteLine();
        Console.WriteLine($"Área del círculo: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}
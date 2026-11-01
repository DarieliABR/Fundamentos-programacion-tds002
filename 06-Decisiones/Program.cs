class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escribe una nota (0-100): ");
        string? textoNota = Console.ReadLine();

        if (int.TryParse(textoNota, out int nota) && nota >= 0 && nota <= 100)
        {
            string letra;

            if (nota >= 90)
            {
                letra = "A";
            }
            else if (nota >= 80)
            {
                letra = "B";
            }
            else if (nota >= 70)
            {
                letra = "C";
            }
            else
            {
                letra = "F";
            }

            Console.WriteLine($"Nota {nota}: letra {letra}");
        }
        else
        {
            Console.WriteLine("Nota inválida. Escribe un número entero entre 0 y 100.");
        }

        Console.WriteLine();

        Console.Write("Primer número: ");
        double numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Segundo número: ");
        double numero2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("1. Sumar  2. Restar  3. Multiplicar  4. Dividir");
        Console.Write("Elige una opción: ");
        int opcion = int.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2:F2}");
                break;
            case 2:
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2:F2}");
                break;
            case 3:
                Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2:F2}");
                break;
            case 4:
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0.");
                }
                else
                {
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2:F2}");
                }
                break;
            default:
                Console.WriteLine("Opción inválida. Elige un número del 1 al 4.");
                break;
        }
    }
}
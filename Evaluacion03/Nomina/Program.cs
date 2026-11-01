class Program
{
    static void Main(string[] args)
    {

        const double TASA_AFP = 0.0287;
        const double TASA_SFS = 0.0304;

        // ENTRADA
        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine()!);

        Console.Write("Pago por hora (RD$): ");
        double pagoPorHora = double.Parse(Console.ReadLine()!);

        // PROCESO
        double salarioBruto = horasTrabajadas * pagoPorHora;
        double descuentoAfp = salarioBruto * TASA_AFP;
        double descuentoSfs = salarioBruto * TASA_SFS;
        double salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

        // SALIDA
        Console.WriteLine();
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: RD$ {salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%):   RD$ {descuentoAfp:N2}");
        Console.WriteLine($"SFS (3.04%):   RD$ {descuentoSfs:N2}");
        Console.WriteLine($"Salario neto:  RD$ {salarioNeto:N2}");
    }
}
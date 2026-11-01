class Program
{
    static void Main(string[] args)
    {
        // Constante: porcentaje del ITBIS
        const double TASA_ITBIS = 0.18;

        // ENTRADA
        Console.Write("Producto: ");
        string producto = Console.ReadLine()!;

        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        Console.Write("Precio unitario (RD$): ");
        double precio = double.Parse(Console.ReadLine()!);

        // PROCESO
        double subtotal = cantidad * precio;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // SALIDA: columnas alineadas con ancho fijo
        Console.WriteLine();
        Console.WriteLine("========== FACTURA ==========");
        Console.WriteLine($"{"Producto",-15}{"Cant.",6}{"Precio",12}{"Importe",14}");
        Console.WriteLine(new string('-', 47));
        Console.WriteLine($"{producto,-15}{cantidad,6}{precio,12:N2}{subtotal,14:N2}");
        Console.WriteLine(new string('-', 47));
        Console.WriteLine($"{"Subtotal:",-33}{subtotal,14:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-33}{itbis,14:N2}");
        Console.WriteLine($"{"TOTAL:",-33}{total,14:N2}");
    }
}
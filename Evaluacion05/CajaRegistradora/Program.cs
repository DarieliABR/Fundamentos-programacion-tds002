class Program
{
    static void Main(string[] args)
    {
        const double TASA_ITBIS = 0.18;

        int cantidadProductos = 0; 
        double subtotal = 0;       
        double precio;

        do
        {
            Console.Write("Precio del producto (0 para terminar): ");
            bool esValido = double.TryParse(Console.ReadLine(), out precio) && precio >= 0;

            if (!esValido)
            {
                Console.WriteLine("Precio inválido. Escribe un número mayor o igual a 0.");
                precio = -1; 
            }
            else if (precio > 0)
            {
                cantidadProductos++;
                subtotal += precio;
            }
        } while (precio != 0);

        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        Console.WriteLine();
        Console.WriteLine($"Productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal: RD$ {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): RD$ {itbis:N2}");
        Console.WriteLine($"Total: RD$ {total:N2}");
    }
}
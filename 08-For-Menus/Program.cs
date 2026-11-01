class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("1. Tablas de multiplicar");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                {
                    Console.WriteLine();
                    for (int fila = 1; fila <= 10; fila++)
                    {
                        for (int columna = 1; columna <= 10; columna++)
                        {
                            Console.Write($"{fila * columna,4}");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                case 2:
                {
                    Console.Write("Número de filas: ");
                    if (int.TryParse(Console.ReadLine(), out int filas) && filas > 0)
                    {
                        for (int fila = 1; fila <= filas; fila++)
                        {
                            for (int asterisco = 1; asterisco <= fila; asterisco++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Escribe un número entero mayor que 0.");
                    }
                    break;
                }
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Elige 1, 2 o 0.");
                    break;
            }
        } while (opcion != 0);
    }
}
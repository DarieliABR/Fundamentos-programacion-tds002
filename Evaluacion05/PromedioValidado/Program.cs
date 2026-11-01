class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;  
        double suma = 0;   
        int mayor = 0;
        int menor = 100;
        bool hayMasNotas = true;

        while (hayMasNotas)
        {
            int nota;
            bool esValida;

            do
            {
                Console.Write("Nota (0-100, o -1 para terminar): ");
                esValida = int.TryParse(Console.ReadLine(), out nota)
                           && (nota == -1 || (nota >= 0 && nota <= 100));

                if (!esValida)
                {
                    Console.WriteLine("Nota inválida. Escribe un entero entre 0 y 100.");
                }
            } while (!esValida);

            if (nota == -1)
            {
                hayMasNotas = false; 
            }
            else
            {
                cantidad++;
                suma += nota;
                if (nota > mayor) mayor = nota;
                if (nota < menor) menor = nota;
            }
        }

        Console.WriteLine();
        if (cantidad == 0)
        {
            Console.WriteLine("No se ingresaron notas.");
        }
        else
        {
            Console.WriteLine($"Promedio: {suma / cantidad:F2}");
            Console.WriteLine($"Nota mayor: {mayor}");
            Console.WriteLine($"Nota menor: {menor}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        const int LIMITE = 12;

        int numero;
        bool esValido;

        {
            Console.Write($"Escribe un número entre 1 y {LIMITE}: ");
            esValido = int.TryParse(Console.ReadLine(), out numero)
                       && numero >= 1 && numero <= LIMITE;

            if (!esValido)
            {
                Console.WriteLine("Número inválido. Inténtalo de nuevo.");
            }
        } while (!esValido);

        int contador = 1;
        int suma = 0;

        Console.WriteLine();
        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        while (contador <= LIMITE)
        {
            int resultado = numero * contador;
            suma += resultado; 
            Console.WriteLine($"{numero} x {contador,2} = {resultado,3}");
            contador++;
        }
      
        Console.WriteLine();
        Console.WriteLine($"Suma de todos los resultados: {suma}");
    }
}
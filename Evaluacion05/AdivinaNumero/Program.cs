class Program
{
    static void Main(string[] args)
    {      
        int secreto = Random.Shared.Next(1, 101);
        int intentos = 0; 
        int intento = 0;

        Console.WriteLine("Adivina el número secreto entre 1 y 100.");
    
        while (intento != secreto)
        {
            Console.Write("Tu número: ");

            if (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100)
            {
                Console.WriteLine("Escribe un número entero entre 1 y 100.");
                intento = 0;
                continue;
            }

            intentos++;

            if (intento < secreto)
            {
                Console.WriteLine("El número secreto es mayor.");
            }
            else if (intento > secreto)
            {
                Console.WriteLine("El número secreto es menor.");
            }
        }

        Console.WriteLine($"¡Acertaste! El número era {secreto}. Intentos: {intentos}");
    }
}
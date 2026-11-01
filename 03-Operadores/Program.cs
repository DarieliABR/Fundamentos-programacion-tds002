class Program
{
    static void Main(string[] args)
    {

        Console.Write("Primer número entero: ");
        int primerNumero = int.Parse(Console.ReadLine()!);

        Console.Write("Segundo número entero: ");
        int segundoNumero = int.Parse(Console.ReadLine()!);

        if (segundoNumero == 0)
        {
            Console.WriteLine("El segundo número no puede ser 0.");
            return;
        }

        int suma = primerNumero + segundoNumero;
        int resta = primerNumero - segundoNumero;
        int producto = primerNumero * segundoNumero;
        double divisionReal = (double)primerNumero / segundoNumero;
        int divisionEntera = primerNumero / segundoNumero;
        int residuo = primerNumero % segundoNumero;
        bool esPar = primerNumero % 2 == 0;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"División real: {divisionReal:F2}");
        Console.WriteLine($"División entera: {divisionEntera}");
        Console.WriteLine($"Residuo: {residuo}");
        Console.WriteLine($"¿El primero es par?: {esPar}");
    }
}

/*
PRUEBA DE ESCRITORIO (x = 10, y = 3)
x = primerNumero, y = segundoNumero

Paso | Instrucción                       | x  | y | Resultado
1    | lee primerNumero                  | 10 | - | x = 10
2    | lee segundoNumero                 | 10 | 3 | y = 3
3    | segundoNumero == 0                | 10 | 3 | false, continúa
4    | suma = x + y                      | 10 | 3 | 13
5    | resta = x - y                     | 10 | 3 | 7
6    | producto = x * y                  | 10 | 3 | 30
7    | divisionReal = (double)x / y      | 10 | 3 | 3.3333... (se muestra 3.33)
8    | divisionEntera = x / y            | 10 | 3 | 3
9    | residuo = x % y                   | 10 | 3 | 1
10   | esPar = x % 2 == 0                | 10 | 3 | 10 % 2 = 0, true

Salida en pantalla:
Suma: 13
Resta: 7
Producto: 30
División real: 3.33
División entera: 3
Residuo: 1
¿El primero es par?: True
*/

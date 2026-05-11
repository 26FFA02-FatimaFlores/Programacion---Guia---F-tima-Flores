internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int num = 2; num <= 50; num++)
        {
            bool esPrimo = true;

            for (int divisor = 2; divisor <= num - 1; divisor++)
            {
                if (num % divisor == 0)
                {
                    esPrimo = false;
                }
            }

            if (esPrimo)
            {
                Console.WriteLine(num + " es primo");
                suma = suma + num;
            }
        }

        Console.WriteLine("La suma de los primos entre 1 y 50 es: " + suma);
        Console.ReadKey();
    }
}
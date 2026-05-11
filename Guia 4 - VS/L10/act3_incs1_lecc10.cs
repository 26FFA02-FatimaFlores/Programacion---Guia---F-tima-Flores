internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int num = 2; num <= 22; num++)
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
                suma = suma + num;
                Console.WriteLine(num + " es primo | Suma acumulada: " + suma);
            }
        }

        Console.WriteLine("Suma total de primos entre 1 y 22: " + suma);
        Console.ReadKey();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int cantPrimos = 0;
        int cantPares = 0;
        int sumaPares = 0;

        for (int num = 300; num >= 1; num--)
        {
            if (num % 2 == 0)
            {
                cantPares = cantPares + 1;
                sumaPares = sumaPares + num;
            }

            bool esPrimo = true;
            if (num <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int divisor = 2; divisor <= num - 1; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        esPrimo = false;
                    }
                }
            }

            if (esPrimo)
            {
                cantPrimos = cantPrimos + 1;
            }
        }

        Console.WriteLine("Cantidad de primos entre 300 y 1: " + cantPrimos);
        Console.WriteLine("Cantidad de pares entre 300 y 1: " + cantPares);
        Console.WriteLine("Suma de pares: " + sumaPares);
        Console.ReadKey();
    }
}
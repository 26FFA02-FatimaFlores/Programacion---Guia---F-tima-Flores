internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;
        int suma = 0;

        for (int num = 2; num <= 100; num++)
        {
            bool espim = true;

            for (int divisor = 2; divisor <= num - 1; divisor++)
            {
                if (num % divisor == 0)
                {
                    espim = false;
                }
            }

            if (espim)
            {
                Console.WriteLine(num);
                contador = contador + 1;
                suma = suma + num;
            }
        }

        Console.WriteLine("Cantidad de primos: " + contador);
        Console.WriteLine("Suma de primos: " + suma);
        Console.ReadKey();
    }
}
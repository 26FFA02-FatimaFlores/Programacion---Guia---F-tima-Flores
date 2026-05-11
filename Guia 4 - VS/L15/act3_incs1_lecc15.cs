internal class Program
{
    private static void Main(string[] args)
    {
        int cantPares = 0;
        int sumaPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            int multiplo = 7 * i;
            Console.WriteLine(multiplo);

            if (multiplo % 2 == 0)
            {
                cantPares = cantPares + 1;
                sumaPares = sumaPares + multiplo;
            }
        }

        Console.WriteLine("Cantidad de pares: " + cantPares);
        Console.WriteLine("Suma de pares: " + sumaPares);
        Console.ReadKey();
    }
}
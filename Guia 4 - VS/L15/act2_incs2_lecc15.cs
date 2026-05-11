internal class Program
{
    private static void Main(string[] args)
    {
        int cant100 = 0;
        int total = 0;
        int billete;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingresa denominación del billete " + i + " ($20, $50 o $100): ");
            billete = Convert.ToInt32(Console.ReadLine());

            if (billete == 100)
            {
                cant100 = cant100 + 1;
            }

            total = total + billete;
        }

        Console.WriteLine("Cantidad de billetes de $100: " + cant100);
        Console.WriteLine("Total de dinero: $" + total);
        Console.ReadKey();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;

        do
        {
            Console.Write("Ingresa un número (9 para terminar): ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 9)
            {
                suma = suma + num;
            }
        }
        while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
        Console.ReadKey();
    }
}
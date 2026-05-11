internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el número menor: ");
        int me = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el número mayor: ");
        int ma = Convert.ToInt32(Console.ReadLine());

        int num = me;

        do
        {
            if (num % 4 == 0)
            {
                Console.WriteLine(num);
            }
            num = num + 1;
        }
        while (num <= ma);

        Console.ReadKey();
    }
}
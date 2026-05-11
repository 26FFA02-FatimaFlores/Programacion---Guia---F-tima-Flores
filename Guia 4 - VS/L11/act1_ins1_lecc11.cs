internal class Program
{
    private static void Main(string[] args)
    {
        int autos = 0;

        do
        {
            autos = autos + 1;
            Console.WriteLine("Cajones disponibles: " + (200 - autos));
        }
        while (autos < 200);

        Console.WriteLine("Ya no hay cajones libres");
        Console.ReadKey();
    }
}
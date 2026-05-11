internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el límite N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int numero = 2; numero <= N; numero += 2)
        {
            Console.WriteLine(numero);
        }
        Console.ReadKey();
    }
}
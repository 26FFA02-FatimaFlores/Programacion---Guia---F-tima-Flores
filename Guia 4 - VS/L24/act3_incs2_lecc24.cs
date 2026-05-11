internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa un número: ");
        int N = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int num = N; num >= 1; num--)
        {
            Console.WriteLine(num);
            suma = suma + num;
        }

        Console.WriteLine("La suma es: " + suma);
        Console.ReadKey();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int f = 1;
        int i = num;

        do
        {
            f = f * i;
            i = i - 1;
        }
        while (i > 1);

        Console.WriteLine("El factorial de " + num + " es: " + f);
        Console.ReadKey();
    }
}
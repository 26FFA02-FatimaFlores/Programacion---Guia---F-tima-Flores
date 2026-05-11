internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingresa el número menor: ");
        int me = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el número mayor: ");
        int ma = Convert.ToInt32(Console.ReadLine());

        int num = me + 1;
        int suma = 0;

        do
        {
            suma = suma + num;
            num = num + 1;
        }
        while (num < ma);

        Console.WriteLine("La suma de todos los enteros es: " + suma);
        Console.ReadKey();
    }
}
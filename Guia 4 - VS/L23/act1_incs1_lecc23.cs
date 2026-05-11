internal class Program
{
    private static void Main(string[] args)
    {
        double peso = 0;

        while (peso < 1)
        {
            Console.Write("Ingresa el peso actual en la báscula (kg): ");
            peso = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("¡Ya tienes 1 kilo de manzanas!");
        Console.ReadKey();
    }
}
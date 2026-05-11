internal class Program
{
    private static void Main(string[] args)
    {
        int N;

        Console.Write("Ingresa un número mayor a 20: ");
        N = Convert.ToInt32(Console.ReadLine());

        while (N <= 20)
        {
            Console.Write("El número debe ser mayor a 20, intenta de nuevo: ");
            N = Convert.ToInt32(Console.ReadLine());
        }

        int numero = 21;
        while (numero < N)
        {
            Console.WriteLine(numero);
            numero = numero + 2;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingresa el número para su tabla de multiplicar: ");
        num = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
            i = i + 1;
        }
    }
}
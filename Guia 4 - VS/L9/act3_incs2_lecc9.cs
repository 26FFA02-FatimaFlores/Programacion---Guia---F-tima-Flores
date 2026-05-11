internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        bool esprimo = true;

        Console.Write("Ingresa un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            esprimo = false;
        }
        else
        {
            int divisor = 2;
            while (divisor <= num - 1)
            {
                if (num % divisor == 0)
                {
                    esprimo = false;
                }
                divisor = divisor + 1;
            }
        }

        if (esprimo)
            Console.WriteLine(num + " ES un número primo");
        else
            Console.WriteLine(num + " NO ES UN NUMERO PRIMO");
    }
}
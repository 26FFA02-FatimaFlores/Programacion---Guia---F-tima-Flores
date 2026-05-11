internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int tboletos = 0;
        double tdinero = 0;

        do
        {
            Console.Write("¿Niño (1) o Adulto (2)? 0 para terminar: ");
            tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    tboletos = tboletos + 1;
                    tdinero = tdinero + 10;
                    break;
                case 2:
                    tboletos = tboletos + 1;
                    tdinero = tdinero + 15;
                    break;
            }

            if (tipo != 0)
            {
                Console.WriteLine("Boletos vendidos: " + tboletos);
                Console.WriteLine("Total cobrado: $" + tdinero);
            }
        }
        while (tipo != 0);

        Console.WriteLine("--- RESUMEN FINAL ---");
        Console.WriteLine("Total boletos vendidos: " + tboletos);
        Console.WriteLine("Total cobrado: $" + tdinero);
        Console.ReadKey();
    }
}
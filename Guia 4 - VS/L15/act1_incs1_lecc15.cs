internal class Program
{
    private static void Main(string[] args)
    {
        int tipo;
        int tboletos = 0;
        int badulto = 0;
        int bnino = 0;
        double tdinero = 0;

        do
        {
            Console.Write("¿Tipo de boleto? (1=Adulto $15, 2=Niño $10, 0=Terminar): ");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                badulto = badulto + 1;
                tboletos = tboletos + 1;
                tdinero = tdinero + 15;
            }
            if (tipo == 2)
            {
                bnino = bnino + 1;
                tboletos = tboletos + 1;
                tdinero = tdinero + 10;
            }

            Console.WriteLine("Boletos vendidos: " + tboletos + " | Total cobrado: $" + tdinero);
        }
        while (tipo != 0);

        Console.WriteLine("--- RESUMEN ---");
        Console.WriteLine("Boletos adulto: " + badulto);
        Console.WriteLine("Boletos niño: " + bnino);
        Console.WriteLine("Total boletos: " + tboletos);
        Console.WriteLine("Total cobrado: $" + tdinero);
        Console.ReadKey();
    }
}
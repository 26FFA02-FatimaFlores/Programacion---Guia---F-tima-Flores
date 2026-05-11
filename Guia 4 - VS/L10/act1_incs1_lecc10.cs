internal class Program
{
    private static void Main(string[] args)
    {
        for (int corte = 1; corte <= 8; corte++)
        {
            Console.WriteLine("Sello " + corte + " de 8 acumulado");
        }
        Console.WriteLine("Obtuviste tu corte gratis,Felicidades");
        Console.ReadKey();
    }
}
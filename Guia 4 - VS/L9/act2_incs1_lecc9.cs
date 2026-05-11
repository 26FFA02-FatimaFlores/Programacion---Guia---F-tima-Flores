internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;
        int ganadas;

        while (monedas < 350)
        {
            Console.WriteLine("Monedas actuales: " + monedas);
            Console.Write("¿Cuántas monedas ganaste en esta ronda? ");
            ganadas = Convert.ToInt32(Console.ReadLine());
            monedas = monedas + ganadas;
        }

        Console.WriteLine("Desbloqueaste el nivel 5 - Tienes " + monedas + " monedas.");
        Console.WriteLine("Pasa al Siguiente nivel bro...");
    }
}
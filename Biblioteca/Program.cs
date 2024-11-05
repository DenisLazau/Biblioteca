using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca();

        biblioteca.AdaugaMembru("Denis", "0777 777 777", "Cazaban 30");
        biblioteca.AdaugaCarte("Righting Software", "Juval Lowy");

        Console.WriteLine($"Hello, World!, {biblioteca}");
    }
}
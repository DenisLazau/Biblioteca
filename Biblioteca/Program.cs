using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca(new List<Membru>(), new List<Carte>());

        Console.WriteLine($"Hello, World!, {biblioteca}");
    }
}
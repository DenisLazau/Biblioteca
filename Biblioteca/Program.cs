using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        Biblioteca.Biblioteca biblioteca = new Biblioteca.Biblioteca();

        biblioteca.AdaugaMembru("Denis", "0777 777 777", "Cazaban 30");
        
        CarteParamFactory carteParamFactory = new CarteParamFactory("Juval Lowy", "Righting Software");
        biblioteca.AdaugaElement(carteParamFactory);

        FormatAfisare afisare = new FormatAfisare();
        //Console.WriteLine(afisare.Visit(biblioteca.GetElement(0)));

        Console.WriteLine($"Hello, World!, {biblioteca}");
    }
}
using FigureDLL;

internal class Program
{
    static void Main(string[] args)
    {
        Quadrato quadrato = new Quadrato(5);
        Console.WriteLine($"Perimetro quadrato: {quadrato.Perimetro()}");
        Console.WriteLine($"Area quadrato: {quadrato.Area()}\n");

        Rettangolo rettangolo = new Rettangolo(3, 4);
        Console.WriteLine($"Perimetro rettangolo: {rettangolo.Perimetro()}");
        Console.WriteLine($"Area rettangolo: {rettangolo.Area()}\n");

        Cerchio cerchio = new Cerchio(4.32);
        Console.WriteLine($"Perimetro triangolo: {cerchio.Perimetro()}");
        Console.WriteLine($"Area triangolo: {cerchio.Area()}");
    }
}

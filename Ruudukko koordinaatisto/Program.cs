using System;

public struct Koordinaatti
{
    public readonly int X;
    public readonly int Y;

    public Koordinaatti(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool OnVieressa(Koordinaatti toinen)
    {
        // Tarkista, ovatko X- ja Y-koordinaatit toisen koordinaatin vieressä
        return Math.Abs(X - toinen.X) <= 1 && Math.Abs(Y - toinen.Y) <= 1;
    }
}

class Program
{
    static void Main()
    {
        Koordinaatti koordinaatti1 = new Koordinaatti(1, 1);
        Koordinaatti koordinaatti2 = new Koordinaatti(2, 2);
        Koordinaatti koordinaatti3 = new Koordinaatti(4, 4);

        Console.WriteLine("Koordinaatti 1: ({0}, {1})", koordinaatti1.X, koordinaatti1.Y);
        Console.WriteLine("Koordinaatti 2: ({0}, {1})", koordinaatti2.X, koordinaatti2.Y);
        Console.WriteLine("Koordinaatti 3: ({0}, {1})", koordinaatti3.X, koordinaatti3.Y);

        Console.WriteLine("Koordinaatti 1 ja 2 ovat vieressä: " + koordinaatti1.OnVieressa(koordinaatti2));
        Console.WriteLine("Koordinaatti 1 ja 3 ovat vieressä: " + koordinaatti1.OnVieressa(koordinaatti3));

        Console.ReadLine();
    }
}
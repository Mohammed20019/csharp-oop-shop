using System;

public class Prodotto
{
    private readonly int codice;
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    private double prezzo;
    private double iva;

    public Prodotto()
    {
        Random rnd = new Random();
        codice = rnd.Next(1000, 9999);
    }

    public double Prezzo
    {
        get { return prezzo; }
        set { prezzo = value; }
    }

    public double IVA
    {
        get { return iva; }
        set { iva = value; }
    }

    public double PrezzoConIVA()
    {
        return prezzo * (1 + iva / 100);
    }

    public double PrezzoBase()
    {
        return prezzo;
    }

    public string NomeEsteso()
    {
        return codice + " " + Nome;
    }
}

public class Program
{
    public static void Main()
    {
        Prodotto p1 = new Prodotto();
        p1.Nome = "Prodotto 1";
        p1.Descrizione = "Descrizione prodotto 1";
        p1.Prezzo = 10.0;
        p1.IVA = 22.0;

        Console.WriteLine("Codice prodotto 1: " + p1.NomeEsteso());
        Console.WriteLine("Prezzo base prodotto 1: " + p1.PrezzoBase());
        Console.WriteLine("Prezzo con IVA prodotto 1: " + p1.PrezzoConIVA());

        Prodotto p2 = new Prodotto();
        p2.Nome = "Prodotto 2";
        p2.Descrizione = "Descrizione prodotto 2";
        p2.Prezzo = 15.0;
        p2.IVA = 22.0;

        Console.WriteLine("Codice prodotto 2: " + p2.NomeEsteso());
        Console.WriteLine("Prezzo base prodotto 2: " + p2.PrezzoBase());
        Console.WriteLine("Prezzo con IVA prodotto 2: " + p2.PrezzoConIVA());
    }
}
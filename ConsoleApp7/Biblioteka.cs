namespace ConsoleApp7;

public class Biblioteka
{
    public List<Ksiazka> ksiazki = new List<Ksiazka>();
    private IZapis _zapis;

    public Biblioteka(IZapis zapis)
    {
        _zapis = zapis;
        ksiazki = _zapis.ZaladujKsiazki();
    }

    public void DodajKsiazke(Ksiazka nowaKsiazka)
    {
        int id = 1;
        if (ksiazki.Any())
        {
            Ksiazka ostatniaKsiazka = ksiazki.MaxBy(p => p.Id);
            id = ostatniaKsiazka.Id + 1;
        }

        nowaKsiazka.Id = id;

        ksiazki.Add(nowaKsiazka);
        _zapis.ZapiszKsiazki(ksiazki);
        Console.WriteLine($"Dodano książkę: {nowaKsiazka.Tytul}");
    }

    public void WyswietlKsiazki()
    {
        if (ksiazki.Count == 0)
        {
            Console.WriteLine("Sorry biedaku, ale nie masz jeszcze książek!");
            return;
        }

        Console.WriteLine("Książki dostępne w bibliotece:");
        foreach (Ksiazka ksiazka in ksiazki)
        {
            ksiazka.WyswietlInformacjeOKsiazce();
        }
    }
}
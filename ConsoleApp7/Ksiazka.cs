namespace ConsoleApp7;

public class Ksiazka
{
    public int Id { get; set; }
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int DataPublikacji { get; set; }
    
    public bool CzyPrzeczytana { get; set; }

    public Ksiazka(string tytul, string autor, int dataPublikacji, bool czyPrzeczytana)
    {
        Tytul = tytul;
        Autor = autor;
        DataPublikacji = dataPublikacji;
        CzyPrzeczytana = czyPrzeczytana;
    }
    
    public Ksiazka(int id, string tytul, string autor, int dataPublikacji, bool czyPrzeczytana)
    {
        Id = id;
        Tytul = tytul;
        Autor = autor;
        DataPublikacji = dataPublikacji;
        CzyPrzeczytana = czyPrzeczytana;
    }

    public void WyswietlInformacjeOKsiazce()
    {
        string przeczytana = CzyPrzeczytana ? "Przeczytana" : "Nieprzeczytana";
        Console.WriteLine($"Id: {Id}, Autor: {Autor}, Tytul: {Tytul}, Data Publikacji: {DataPublikacji}, Status: {przeczytana}");
    }
}
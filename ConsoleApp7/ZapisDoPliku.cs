namespace ConsoleApp7;

public class ZapisDoPliku : IZapis
{
    private string sciezkaDoPliku = "dane_biblioteki.txt";

    public void ZapiszKsiazki(List<Ksiazka> ksiazki)
    {
        using (StreamWriter writer = new StreamWriter(sciezkaDoPliku))
        {
            foreach (Ksiazka ksiazka in ksiazki)
            {
                int status = ksiazka.CzyPrzeczytana ? 1 : 0;
                writer.WriteLine($"{ksiazka.Id}|{ksiazka.Tytul}|{ksiazka.Autor}|{ksiazka.DataPublikacji}|{status}");
            }
        }
    }

    public List<Ksiazka> ZaladujKsiazki()
    {
        List<Ksiazka> ksiazki = new List<Ksiazka>();
        if (File.Exists(sciezkaDoPliku))
        {
            using (StreamReader reader = new StreamReader(sciezkaDoPliku))
            {
                string linia;

                while ((linia = reader.ReadLine()) != null)
                {
                    string[] elementy = linia.Split('|');
                    if (elementy.Length == 5)
                    {
                        int id;
                        int.TryParse(elementy[0], out id);
                        int dataPublikacji;
                        int.TryParse(elementy[3], out dataPublikacji);
                        int status;
                        int.TryParse(elementy[4], out status);
                        bool czyPrzeczytana = status == 1;
                        Ksiazka ksiazka = new Ksiazka(id, elementy[1], elementy[2],
                            dataPublikacji, czyPrzeczytana);
                        ksiazki.Add(ksiazka);
                    }
                }
            }
        }
        return ksiazki;
    }
}
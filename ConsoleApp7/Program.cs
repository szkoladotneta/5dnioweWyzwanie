//Aplikacja konsolowa - zarzadzenia biblioteka


using ConsoleApp7;

ZapisDoPliku pliki = new ZapisDoPliku();
Biblioteka biblio = new Biblioteka(pliki);

bool czyKontynuowac = true;

while (czyKontynuowac)
{
    Console.WriteLine("Witaj w systemie zarządzania biblioteką");
    Console.WriteLine("Wybierz dostępną operację:");
    Console.WriteLine("1. Dodaj książkę");
    Console.WriteLine("2. Wyświetl książki");
    Console.WriteLine("3. Wyjdź z aplikacji");
    Console.WriteLine("Wpisz numer operacji i zatwierdź Enterem:");

    string operacja = Console.ReadLine();

    switch (operacja)
    {
        case "1":
            Console.WriteLine("Wpisz tytuł i zatwierdź enterem:");
            string tytul = Console.ReadLine();
            Console.WriteLine("Wpisz autora i zatwierdź enterem:");
            string autor = Console.ReadLine();
            Console.WriteLine("Wpisz datę publikacji i zatwierdź enterem:");
            string dataPublikacjiTekst = Console.ReadLine();
            int dataPublikacji;
            int.TryParse(dataPublikacjiTekst, out dataPublikacji);
            Console.WriteLine("Wpisz TAK jeśli książka była przeczytana,");
            Console.WriteLine("Wpisz NIE jeśli książka nie była przeczytana");
            string przeczytana = Console.ReadLine();
            bool czyPrzeczytana = false;
            switch (przeczytana)
            {
                case "TAK":
                    czyPrzeczytana = true;
                    break;
                case "NIE":
                    czyPrzeczytana = false;
                    break;
                default:
                    Console.WriteLine("Nie rozpoznano wartości statusu książki.");
                    break;
            }

            Ksiazka ksiazka = new Ksiazka(tytul, autor, dataPublikacji, czyPrzeczytana);
            biblio.DodajKsiazke(ksiazka);
            break;
        case "2":
            biblio.WyswietlKsiazki();
            break;
        case "3":
            czyKontynuowac = false;
            Console.WriteLine("Zamykam aplikację...");
            break;
        default:
            Console.WriteLine("Nie ma takiej operacji. Spróbuj ponownie...");
            break;
    }
}

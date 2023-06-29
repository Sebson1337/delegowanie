using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę sekund: ");
        int sekundy = Convert.ToInt32(Console.ReadLine());
        
        string sformatowanyCzas = FormatujCzas(sekundy);
        Console.WriteLine(sformatowanyCzas);
    }

    static string FormatujCzas(int sekundy)
    {
        int godziny = sekundy / 3600;
        int minuty = (sekundy % 3600) / 60;
        int resztaSekund = sekundy % 60;

        string sformatowaneGodziny = godziny.ToString("D2");
        string sformatowaneMinuty = minuty.ToString("D2");
        string sformatowaneSekundy = resztaSekund.ToString("D2");

        string sformatowanyCzas = $"{sformatowaneGodziny}:{sformatowaneMinuty}:{sformatowaneSekundy}";
        return sformatowanyCzas;
    }
}
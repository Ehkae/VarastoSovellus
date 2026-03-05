using System;

namespace VarastoSovellus
{
    class Ohjelma
    {
        static void Main(string[] args)
        {
            // Luodaan uusi varasto-olio
            Varasto varasto = new Varasto();

            // Luodaan eri tyyppisiä tuotteita (POLYMORFISMI)
            Tuote tuote1 = new ElektroniikkaTuote("Tietokone", 999.99m, 10, 24);
            Tuote tuote2 = new RuokaTuote("Maito", 2.50m, 50, DateTime.Now.AddDays(2));
            Tuote tuote3 = new ElektroniikkaTuote("Näyttö", 199.99m, 20, 12);
            Tuote tuote4 = new VaateTuote("T-paita", 19.99m, 100, "M", "Sininen");
            Tuote tuote5 = new RuokaTuote("Leipä", 3.20m, 30, DateTime.Now.AddDays(7));

            // Lisätään tuotteita varastoon
            varasto.LisaaTuote(tuote1);
            varasto.LisaaTuote(tuote2);
            varasto.LisaaTuote(tuote3);
            varasto.LisaaTuote(tuote4);
            varasto.LisaaTuote(tuote5);

            // Näytetään kaikki tuotteet varastossa
            varasto.NaytaKaikkiTuotteet();

            // RAJAPINNAN KÄYTTÖ - käsitellään alennettavia tuotteita
            Console.WriteLine("\n=== ALENNETTAVAT TUOTTEET ===");
            varasto.KasitteleAlennettavatTuotteet(15m);

            Console.WriteLine("\n=== POLYMORFISMIN DEMONSTRAATIO ===");
            // Poistetaan tuote varastosta
            varasto.PoistaTuote("Maito");

            // Näytetään päivitetty varaston sisältö
            varasto.NaytaKaikkiTuotteet();
        }
    }
}
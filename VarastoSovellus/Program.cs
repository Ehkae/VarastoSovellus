using System;

namespace VarastoSovellus
{
    class Ohjelma
    {
        static void Main(string[] args)
        {
            // Luodaan uusi varasto-olio
            Varasto varasto = new Varasto();

            // Luodaan tuotteita
            Tuote tuote1 = new Tuote("Tietokone", 999.99m, 10);
            Tuote tuote2 = new Tuote("Hiiri", 25.50m, 50);
            Tuote tuote3 = new Tuote("Näyttö", 199.99m, 20);

            // Lisätään tuotteita varastoon
            varasto.LisaaTuote(tuote1);
            varasto.LisaaTuote(tuote2);
            varasto.LisaaTuote(tuote3);

            // Näytetään kaikki tuotteet varastossa
            varasto.NaytaKaikkiTuotteet();

            // Poistetaan tuote varastosta
            varasto.PoistaTuote("Hiiri");

            // Näytetään päivitetty varaston sisältö
            varasto.NaytaKaikkiTuotteet();
        }
    }
}
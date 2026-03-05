using System;

namespace VarastoSovellus
{
    // Tuote-luokka sisältää tuotteen tiedot
    public class Tuote
    {
        public string Nimi { get; set; }
        public decimal Hinta { get; set; }
        public int Maara { get; set; }

        // Konstruktori tuottaa tuotteen perustiedot
        public Tuote(string nimi, decimal hinta, int maara)
        {
            Nimi = nimi;
            Hinta = hinta;
            Maara = maara;
        }

        // Näytetään tuotteen tiedot (virtual mahdollistaa polymorfismin)
        public virtual void NaytaTiedot()
        {
            Console.WriteLine($"Tuote: {Nimi}, Hinta: {Hinta} €, Määrä: {Maara} kpl");
        }
    }
}
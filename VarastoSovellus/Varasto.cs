using System;
using System.Collections.Generic;

namespace VarastoSovellus
{
    // Varasto-luokka hallinnoi tuotteita
    public class Varasto
    {
        // Yksityinen lista tallentaa varaston tuotteet
        private List<Tuote> _tuotteet = new List<Tuote>();

        // Metodi lisää tuotteen varastoon
        public void LisaaTuote(Tuote tuote)
        {
            _tuotteet.Add(tuote);
            Console.WriteLine($"Tuote {tuote.Nimi} lisätty varastoon.");
        }

        // Metodi poistaa tuotteen varastosta
        public void PoistaTuote(string tuotteenNimi)
        {
            var tuote = _tuotteet.Find(t => t.Nimi == tuotteenNimi);
            if (tuote != null)
            {
                _tuotteet.Remove(tuote);
                Console.WriteLine($"Tuote {tuotteenNimi} poistettu varastosta.");
            }
            else
            {
                Console.WriteLine($"Tuotetta {tuotteenNimi} ei löytynyt varastosta.");
            }
        }

        // Metodi näyttää kaikki varastossa olevat tuotteet
        public void NaytaKaikkiTuotteet()
        {
            Console.WriteLine("\nVaraston sisältö:");
            foreach (var tuote in _tuotteet)
            {
                tuote.NaytaTiedot();
            }
        }
    }
}
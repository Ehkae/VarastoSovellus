using System;

namespace VarastoSovellus
{
    // RuokaTuote perii Tuote-luokan ja toteuttaa IAlennettava-rajapinnan
    public class RuokaTuote : Tuote, IAlennettava
    {
        public DateTime Viimeinen_Kayttopaiva { get; set; }

        public RuokaTuote(string nimi, decimal hinta, int maara, DateTime viimeinenKayttopaiva)
            : base(nimi, hinta, maara)
        {
            Viimeinen_Kayttopaiva = viimeinenKayttopaiva;
        }

        // Polymorfinen metodi - ylikirjoittaa kantaluokan metodin
        public override void NaytaTiedot()
        {
            Console.WriteLine($"[RUOKA] {Nimi}, Hinta: {Hinta} €, Määrä: {Maara} kpl, Viim. käyttöpäivä: {Viimeinen_Kayttopaiva:dd.MM.yyyy}");
        }

        // Rajapinnan toteutus - ruoka saa suuremman alennuksen lähellä vanhenemista
        public decimal LaskeAlennettuHinta(decimal alennusProsentti)
        {
            var paivatViimeiseen = (Viimeinen_Kayttopaiva - DateTime.Now).Days;
            
            if (paivatViimeiseen <= 3)
            {
                // Ekstra alennus, jos vanhenee pian
                alennusProsentti += 20;
            }
            
            return Hinta * (1 - alennusProsentti / 100);
        }

        public void NaytaAlennusTiedot()
        {
            var paivatViimeiseen = (Viimeinen_Kayttopaiva - DateTime.Now).Days;
            if (paivatViimeiseen <= 3)
            {
                Console.WriteLine($"  Ruokatuote vanhenee {paivatViimeiseen} päivän päästä - EKSTRA ALENNUS!");
            }
            else
            {
                Console.WriteLine($"  Ruokatuote vanhenee {paivatViimeiseen} päivän päästä.");
            }
        }
    }
}
using System;

namespace VarastoSovellus
{
    // ElektroniikkaTuote perii Tuote-luokan ja toteuttaa IAlennettava-rajapinnan
    public class ElektroniikkaTuote : Tuote, IAlennettava
    {
        public int TakuuAika { get; set; } // Takuuaika kuukausina

        public ElektroniikkaTuote(string nimi, decimal hinta, int maara, int takuuAika)
            : base(nimi, hinta, maara)
        {
            TakuuAika = takuuAika;
        }

        // Polymorfinen metodi - ylikirjoittaa kantaluokan metodin
        public override void NaytaTiedot()
        {
            Console.WriteLine($"[ELEKTRONIIKKA] {Nimi}, Hinta: {Hinta} Ä, M‰‰r‰: {Maara} kpl, Takuu: {TakuuAika} kk");
        }

        // Rajapinnan toteutus
        public decimal LaskeAlennettuHinta(decimal alennusProsentti)
        {
            return Hinta * (1 - alennusProsentti / 100);
        }

        public void NaytaAlennusTiedot()
        {
            Console.WriteLine($"  Elektroniikkatuotteelle voidaan antaa jopa 30% alennus.");
        }
    }
}
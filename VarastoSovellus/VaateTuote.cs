using System;

namespace VarastoSovellus
{
    // VaateTuote perii Tuote-luokan
    public class VaateTuote : Tuote
    {
        public string Koko { get; set; }
        public string Vari { get; set; }

        public VaateTuote(string nimi, decimal hinta, int maara, string koko, string vari)
            : base(nimi, hinta, maara)
        {
            Koko = koko;
            Vari = vari;
        }

        // Polymorfinen metodi - ylikirjoittaa kantaluokan metodin
        public override void NaytaTiedot()
        {
            Console.WriteLine($"[VAATE] {Nimi}, Hinta: {Hinta} Ä, M‰‰r‰: {Maara} kpl, Koko: {Koko}, V‰ri: {Vari}");
        }
    }
}
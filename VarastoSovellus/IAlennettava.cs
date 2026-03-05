using System;

namespace VarastoSovellus
{
    // Rajapinta m‰‰ritt‰‰ alennettavien tuotteiden toiminnallisuuden
    public interface IAlennettava
    {
        decimal LaskeAlennettuHinta(decimal alennusProsentti);
        void NaytaAlennusTiedot();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upisi_klijenta_u_listu
{
    internal class Klijent
    {
        private int sifra;
        private string vrstaKlijenta;
        private string imeNaziv;
        private string prezimeKontaktOsoba;
        private string adresa;

        public Klijent(int sifra, string vrstaKlijenta, string imeNaziv, string prezimeKontaktOsoba, string adresa)
        {
            this.Sifra = sifra;
            this.VrstaKlijenta = vrstaKlijenta;
            this.ImeNaziv = imeNaziv;
            this.PrezimeKontaktOsoba = prezimeKontaktOsoba;
            this.Adresa = adresa;
        }

        public int Sifra { get => sifra; set => sifra = value; }
        public string VrstaKlijenta { get => vrstaKlijenta; set => vrstaKlijenta = value; }
        public string ImeNaziv { get => imeNaziv; set => imeNaziv = value; }
        public string PrezimeKontaktOsoba { get => prezimeKontaktOsoba; set => prezimeKontaktOsoba = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return string.Format($"Sifra {sifra} , ime {imeNaziv} i prezime {prezimeKontaktOsoba} na adresi {adresa} dok je vrsta {vrstaKlijenta}");
        }
    }
}
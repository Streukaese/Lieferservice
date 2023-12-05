using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lieferservice
{
    public class Artikel
    {
        public long Id { get; set; }
        public string ArtikelBezeichnung { get; set; }
        public int Preis { get; set; }
        public int Anzahl { get; set; }
        public int Gesamtpreis { get; set; }
        public Artikel(long id, string artikelBezeichnung, int preis, int anzahl, int gesamtpreis)
        {
            Id = id;
            ArtikelBezeichnung = artikelBezeichnung;
            Preis = preis;
            Anzahl = anzahl;
            Gesamtpreis = gesamtpreis;
        }

        public override string ToString()
        {
            return ArtikelBezeichnung + " (Preis: " + Preis + "€)";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyBestiarium
{
    internal class Szorny
    {
        int id;
        string nev;
        string veszelyessegiSzint;
        string elohely;
        string foGyengeseg;
        string leggyakoribbZsakmany;
        bool veszelyesE;

        public Szorny(int id, string nev, string veszelyessegiSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegiSzint = veszelyessegiSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get; }
        public string Nev { get; }
        public string VeszelyessegiSzint { get; }
        public string Elohely { get; }
        public string FoGyengeseg { get; }
        public string LeggyakoribbZsakmany { get; }
        public bool VeszelyesE { get; }
    }
}

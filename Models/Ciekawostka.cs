using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using frostpunk2_ciekawostki.Controllers;

namespace frostpunk2_ciekawostki.Models
{
    public class Ciekawostka
    {
        public int CiekawostkaId { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public string ZdjecieURL { get; set; }
        public Kategoria Kategoria { get; set; }

        public Ciekawostka(string Tytul, string Opis, string ZdjecieURL, Kategoria kategoria)
        {
            this.Tytul = Tytul;
            this.Opis = Opis;
            this.ZdjecieURL = ZdjecieURL;
            this.Kategoria = kategoria;
        }
    }
}
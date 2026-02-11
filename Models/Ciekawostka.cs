using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frostpunk2_ciekawostki.Models
{
    public class Ciekawostka
    {
        public int CiekawostkaId { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public List<string> ZdjeciaURL { get; set; }
    }
}
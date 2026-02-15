using frostpunk2_ciekawostki.Controllers;
using frostpunk2_ciekawostki.Models;

namespace frostpunk2_ciekawostki;

public class Test
{
    public static void main(String[] args)
    {
        Kategoria fabularna = new Kategoria("tytul", "opis");
        Ciekawostka ciekawostka = new Ciekawostka("Gramy Henrykiem Wilczkiem", "Opisujemy",
            "images/frostpunk.png", fabularna);
    }
}
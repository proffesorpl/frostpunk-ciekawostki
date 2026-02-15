namespace frostpunk2_ciekawostki.Controllers;

public class Kategoria
{
   public int KategoriaID { get; set; }
   public string Nazwa { get; set; }
   public string Opis { get; set; }

   public Kategoria(string Nazwa, string Opis)
   {
      this.Nazwa = Nazwa;
      this.Opis = Opis;
   }
}
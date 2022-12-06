namespace Projekt.Models
{
    public class Gra
    {
        public Gra(int id, string nazwa, string kategoria, int cena, string opis, string zdjęcie)
        {
            this.Id = id;
            this.Nazwa = nazwa;
            this.Kategoria = kategoria;
            this.Cena = cena;
            this.Opis = opis;
            this.Zdjęcie = zdjęcie;
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public int Cena { get; set; }
        public string Opis { get; set; }

        public string Zdjęcie { get; set; }
    }
}

namespace App6
{

    public class Articolo
    {

        public string? titoloArticolo { get; set; }

        public DateTime? dataPubblicazione { get; set; }

        public Autore? autore { get; set; }

        public Articolo(string titoloArticolo, DateTime dataPubblicazione)
        {

            this.titoloArticolo = titoloArticolo;
            this.dataPubblicazione = dataPubblicazione;

        }




    }




}
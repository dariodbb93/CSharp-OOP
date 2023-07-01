namespace App6
{
    // una classe statica non ha metodo costruttore

    public class Controller
    {

        public static List<Autore> listaAutori { get; } = new List<Autore>();

        public static List<Articolo> listaArticoli { get; } = new List<Articolo>();

        public static Autore creaAutore(string nome, string cognome)
        {

            Autore a = new Autore(nome, cognome);
            // listaAutori.Add(a);

            return a;

        }

        public static Articolo creaArticolo(string titoloArticolo, DateTime dataPubblicazione)
        {

            Articolo b = new Articolo(titoloArticolo, dataPubblicazione);


            return b;

        }
        public static void associaArticolo(Autore autore, List<Articolo> articolo)
        {

            foreach (var element in articolo)
            {

                element.autore = autore;

                listaArticoli.Add(element);
            }

        }


        public static void printArticoli(Autore autore)
        {


            System.Console.WriteLine("Gli articoli scritti da " + autore.cognome + " sono: ");


            foreach (var element in listaArticoli)
            {
                if (element.autore == autore)
                {

                    System.Console.WriteLine(element.titoloArticolo);
                }
            }

        }


    }


}
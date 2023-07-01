using App6;

var svevo = Controller.creaAutore("Italo", "Svevo");
var dario = Controller.creaAutore("Dario", "Del Bel Belluz");
var articolo1 = Controller.creaArticolo("La Coscienza di Zeno", DateTime.Now);
var articolo2 = Controller.creaArticolo("Altri Libertini", DateTime.Now);
var articolo3 = Controller.creaArticolo("Divina Commedia", DateTime.Now);
var articolo4 = Controller.creaArticolo("Programmazione ad Oggetti", DateTime.Today);

Controller.associaArticolo(dario, new List<Articolo> {articolo4});
Controller.printArticoli(dario);













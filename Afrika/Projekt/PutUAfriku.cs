using BoljiSvijetBiblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class BoljiSvijet : Form
    {
        public Ruksak ruksak = new Ruksak();
        private List<Predmet> predmetiURuksaku = new List<Predmet>();
       public BindingSource poveziPredmete = new BindingSource();
        BindingSource poveziRuksak = new BindingSource();
       public BindingSource poveziDobavljace = new BindingSource();
        private decimal cijenaPuta = 0;
        /*Ovime spajamo funkciju SetupData koja puni podatke sa listBoxom u koji se pune podaci.
         * Obratiti pažnju da se radi na razini forme, a ne na razini pojedine metode.
         * 
         * Isto radimo i za punjenje podataka u košaricu.
         */

        public BoljiSvijet()
        {
            InitializeComponent();
            SetupData();

            poveziPredmete.DataSource = ruksak.Predmeti.Where(x => x.Prodano == false).ToList(); //sprema proizvode u datasource
            //sada trebamo povezati listBox i datasource
            predmetiListbox.DataSource = poveziPredmete;
            //i sada trebamo dodati listboxu ono što će prikazivati
            predmetiListbox.DisplayMember = "Prikazi";
            predmetiListbox.ValueMember = "Prikazi";
            /*da bi se nešto moglo prikazivati(svojstvo), moramo ga kreirati.
             * To ćemo izvesti tako da kreiramo novo svojstvo proizvodu i povežemo ga s dva postojeća svojstva - imenom i cijenom
             * To radimo zato što metode itemsListbox-a primaju samo jednu vrijednost
             */
            /*Dakle, objasnimo još jednom:
             * 1. Napravili smo BindingSource.
             * 2. DataSource od tog BindingSource-a smo napunili sa listom Itema iz klase ruksak.
             * 3. Onda smo listBoxov DataSource napunili sa poveziPredmete ( a on sadržava listu itema)
             * 4. Zatim smo rekli listBox-u da prikaže svojstvo Display svakog itema.

            */

            poveziRuksak.DataSource = predmetiURuksaku;
            ruksakListBox.DataSource = poveziRuksak;
            ruksakListBox.DisplayMember = "Prikazi";
            ruksakListBox.ValueMember = "Prikazi";

            poveziDobavljace.DataSource = ruksak.Dobavljaci;
            dobavljaciListbox.DataSource = poveziDobavljace;
            dobavljaciListbox.DisplayMember = "Prikazi"; //čita iz vendor klase
            dobavljaciListbox.ValueMember = "Prikazi";
            
        }
        private void BoljiSvijet_Load(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {
            /*dva načina za dodavanje vendora.
             * 1. Kreiranje Dobavljac objekta:
             *      Dobavljac demoVendor = new Dobavljac();
             *      demoVendor.NazivTvrtke = "Bill";
             *      demoVendor.LastName = "Smith";
             *      demoVendor.Commission = .5;
             *      ruksak.Dobavljaci.Add(demoVendor);
             *      
             *      ako želimo dodati više vendora;
                    demoVendor = new Dobavljac();
             *      demoVendor.NazivTvrtke = "Sue";
             *      demoVendor.LastName = "Jones";
             *      demoVendor.Commission = .5;
             *      ruksak.Dobavljaci.Add(demoVendor);
             *  2. Kreiranje metode u kojoj ćemo kreirati novu istancu tipa vendor. Nakon toga možemo postaviti početne vrijednosti novoj istanci.
             *  To se razlikuje od kreiranja konstrukta koji drži te objekte.
             *  U klasi Dobavljac kreirali smo konstruktor za početnu vrijednost varijable commission, pa njoj ne moramo dodijeljivati početnu vrijednost, jer je dodijeljena defaultno. 
             */
            /*ne zaboraviti istancirati klasu prije pokretanja
            To možemo učiniti ovako:
            ruksak.Dobavljaci = new List<Dobavljaci>();
            Ali ovo nije mjesto gdje je dobro istancirati klasu jer će se tada klasa istancirati svaki put kada se pozove istanca Store. 
            Puno bolja praksa je to učiniti unutar same klase Dobavljac.
            */
            ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = "Ljekarna"}); 
            ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = "Knjižara"});
            //u ovom trenutku imamo 2 vendora. Idemo dodavati proizvode
            ruksak.Predmeti.Add(new Predmet
            {
                Naziv = "Lijek protiv malarije",
                OpisProizvoda = "Medicinska potrebština", //ne smijemo sred stringa prijeći u novi red. Ako to želimo, prije navodnika moramo dodati @
                Cijena = 5M,
                dobavljacProizvoda = ruksak.Dobavljaci[0]
            });
            /*dodali smo vendora prema indeksu, owner je onaj vendor koji je prvi kreiran.
             Dodali smo M pored cijene. Bez M je greška. Slovom M smo rekli kompajleru "Hej, ovo je decimal, a ne double".
             Zašto bi kompajleru to govorili kada smo price definirali kao Decimal tip?
             Zato što kada se ovako izravno doda vrijednost, on ju tumači kao double.
             */
            ruksak.Predmeti.Add(new Predmet
            {
                Naziv = "Povratna karta",
                OpisProizvoda = "Obrazovna potrebština",
                Cijena = 3500M,
                dobavljacProizvoda = ruksak.Dobavljaci[1]
            });

            ruksak.Predmeti.Add(new Predmet
            {
                Naziv = "Bojice",
                OpisProizvoda = "Obrazovna potrebština",
                Cijena = 15M,
                dobavljacProizvoda = ruksak.Dobavljaci[1]
            });

            ruksak.Predmeti.Add(new Predmet
            {
                Naziv = "Olovke",
                OpisProizvoda = "Obrazovna potrebština",
                Cijena = 10M,
                dobavljacProizvoda = ruksak.Dobavljaci[0]
            });

            ruksak.Name = "Be the best you can be";
        }

        private void dodajURuksak_Click(object sender, EventArgs e)
        {
            //Prepoznaje što je odabrano u ItemList
            //Kopira to u Shopping Cart
            //Želimo li obrisati to sa item liste? ne još
          Predmet odabraniPredmet = (Predmet)predmetiListbox.SelectedItem;
          predmetiURuksaku.Add(odabraniPredmet);
          poveziRuksak.ResetBindings(false);


        }

        private void ponesiRuksak_Click(object sender, EventArgs e)
        {
            //označiti svaki proizvod kao prodan. Postavljanje svojstva sold kao true
            //Očisti košaricu

            foreach (Predmet predmet in predmetiURuksaku)
            {
                predmet.Prodano = true;
                // item.dobavljacProizvoda.PaymentDue += (decimal)item.dobavljacProizvoda.Commission * item.Cijena; - ovime računamo koliko smo dužni dobavljaču. Nije relevantno jer želimo izračunati samo ukupnu cijenu puta.
                //cijenaNaračunu += (1 - (decimal)item.dobavljacProizvoda.Commission) * item.Cijena; - ovime računamo saldo (postotak dobavljača*cijenaproizvoda)
                cijenaPuta += predmet.Cijena;
            }
            predmetiURuksaku.Clear();
            poveziPredmete.DataSource = ruksak.Predmeti.Where(x => x.Prodano == false).ToList();
            cijenaPutaValue.Text = string.Format("{0} kn", cijenaPuta);
            poveziRuksak.ResetBindings(false);
            poveziPredmete.ResetBindings(false);
            poveziDobavljace.ResetBindings(false);
            //ovaj dio koda je ključan za osvježavanje prodanih proizvoda.
        }

        private void dodajUListu_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjePotrebnihStvari formaZaDodavanjePotrebnihStvari = new FormaZaDodavanjePotrebnihStvari(this);
            formaZaDodavanjePotrebnihStvari.Show();
        }
        /*pokušaj dodavanja u listbox
        public void Ponovnopostavipodatke(string primljenitekst)
        {
            ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = primljenitekst });
            ruksak.Predmeti.Add(new Predmet {Naziv = primljenitekst});
            poveziPredmete.ResetBindings(false);
            poveziDobavljace.ResetBindings(false);
        }
        */
    }
}

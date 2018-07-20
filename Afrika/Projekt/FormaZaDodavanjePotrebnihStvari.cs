using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoljiSvijetBiblioteka;

namespace Projekt
{
    public partial class FormaZaDodavanjePotrebnihStvari : Form
    {
        BoljiSvijet pristiglaforma;
        public FormaZaDodavanjePotrebnihStvari(BoljiSvijet formakojadolazi)
        {
            pristiglaforma = formakojadolazi;
            InitializeComponent();
            odaberiStoZelisDodatiComboBox.Items.Add("Predmet");
            odaberiStoZelisDodatiComboBox.Items.Add("Dobavljač");

            //   DodajOdabrano();
        }
        /*
        private void DodajOdabrano()
        {
            if Predmet odabraniPredmet = (Predmet)odaberiStoZelisDodatiComboBox.SelectedItem;
            ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = "Ljekarna" });
            ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = "Knjižara" });
        }
        */
        private void FormaZaDodavanjePotrebnihStvari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaProjektaDataSet1.Predmeti' table. You can move, or remove it, as needed.
            this.predmetiTableAdapter.Fill(this.bazaProjektaDataSet1.Predmeti);

        }

        private void gumbZaDodavanjePredmeta_Click(object sender, EventArgs e)
        {
            if (odaberiStoZelisDodatiComboBox.Text == "Predmet")
            {

                pristiglaforma.ruksak.Predmeti.Add(new Predmet { Naziv = unesiStoTiJePotrebnoTextbox.Text });
                //predmetiListbox.refresh() iz baze
                pristiglaforma.poveziPredmete.ResetBindings(false);
            }
            else
            {
                if (odaberiStoZelisDodatiComboBox.Text == "Predmet")
                    pristiglaforma.ruksak.Dobavljaci.Add(new Dobavljac { NazivTvrtke = unesiStoTiJePotrebnoTextbox.Text });
                pristiglaforma.poveziDobavljace.ResetBindings(false);
            }
        }

        private void odaberiStoZelisDodatiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            popisPredmetaLabel.Text = odaberiStoZelisDodatiComboBox.Text;


        }


    }
}

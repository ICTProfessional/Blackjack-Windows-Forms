using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Windows_Forms.Frontend
{
    public partial class Form1 : Form
    {
        Spel spel;
        public Form1()
        {
            InitializeComponent();
            spel = new Spel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_StartSpel_Click(object sender, EventArgs e)
        {
            // Kijkt of er spelers zijn geselecteerd, anders ontstaat een foutmelding
            if (spel.Spelers.Any())
            {
                // Start spel
                // Verander tekst
                lbl_SpelerNaam.Text = spel.GeefHuidigeSpeler().Naam;
                lbl_Punten.Text = spel.GeefHuidigeSpeler().BerekenWaarde().ToString();
                lbl_Kaarten.Text = spel.GeefHuidigeSpeler().GeefKaartenAlsString();

                // Verander knoppen status
                btn_EindigBeurt.Enabled = true;
                btn_TrekKaart.Enabled = true;
                btn_StartSpel.Enabled = false;

            }
            else
            {
                // Foutmelding
                MessageBox.Show("Er zijn geen spelers toegevoegd. Voeg spelers toe door op 'Algemeen -> Voeg spelers toe' te drukken.", "Kan het spel niet starten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void voegSpelersToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Laat speler scherm zien
            VoegSpelerToeScherm spelerScherm = new VoegSpelerToeScherm();
            if (spelerScherm.ShowDialog(this) == DialogResult.OK)
            {
                // Voor elke speler wordt er een naam gegeven
                for (int i = 1; i <= spelerScherm.GeefSpelerAantal(); i++)
                {
                    SpelerNaamScherm naamScherm = new SpelerNaamScherm(i);
                    if (naamScherm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Voeg persoon toe
                        spel.MaakPersoon(naamScherm.GeefNaam(), spel.HuidigeDeck);
                    }
                }
            }
        }
    }
}

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
    public partial class Blackjack : Form
    {
        Spel spel;
        public Blackjack()
        {
            InitializeComponent();
            spel = new Spel();
        }
        /// <summary>
        /// Vult alle labels met de juiste informatie
        /// </summary>
        private void UpdateLabels()
        {
            lbl_Kaarten.Text = spel.GeefHuidigeSpeler().GeefKaartenAlsString();
            lbl_Punten.Text = spel.GeefHuidigeSpeler().BerekenWaarde().ToString();
            lbl_SpelerNaam.Text = spel.GeefHuidigeSpeler().Naam;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_StartSpel_Click(object sender, EventArgs e)
        {
            // Het deck wordt gevuld
            spel.MaakNieuweDeck();
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
                MessageBox.Show("Er zijn geen spelers toegevoegd. Voeg spelers toe door linksboven op 'Algemeen -> Verander spelers' te drukken.", "Kan het spel niet starten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void voegSpelersToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spel.Spelers.Any())
            {
                DialogResult keuze = MessageBox.Show(this, "Let op: alle speler namen gaan weg. Weet je zeker dat je door wilt gaan?", "Waarschuwing", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); ;
                if (keuze == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Reset de lijst
            lb_SpelerLijst.Items.Clear();

            // Laat speler scherm zien

            // Haalt elke speler voor de zekerheid eruit
            spel.Spelers = new List<Persoon>();
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

                // Voegt automatisch een dealer toe
                spel.MaakPersoon("Dealer", spel.HuidigeDeck);

                // Zet spelers in de spelerlijst
                foreach (var speler in spel.Spelers)
                {
                    lb_SpelerLijst.Items.Add(speler.Naam);
                }
            }
        }

        private void btn_TrekKaart_Click(object sender, EventArgs e)
        {
            // Geeft een kaart aan de speler
            spel.GeefHuidigeSpeler().TrekKaart(spel.HuidigeDeck);
            // Updatet de kaarten label
            UpdateLabels();
            // Schakelt de trek kaart knop uit als de waarde over de 21 is
            if (spel.GeefHuidigeSpeler().BerekenWaarde() > 21)
            {
                btn_TrekKaart.Enabled = false;
            }
        }

        private void btn_EindigBeurt_Click(object sender, EventArgs e)
        {
            //Wisselt speler
            spel.WisselHuidigPersoon();
            UpdateLabels();
            btn_TrekKaart.Enabled = true;
            // Checkt of de speler de dealer is
            if (spel.GeefHuidigeSpeler().Naam == "Dealer")
            {
                // De dealer is aan de beurt
                btn_EindigBeurt.Enabled = false;
                btn_TrekKaart.Enabled = false;
                // Als de waarde van de dealer lager is dan 17
                while (spel.GeefHuidigeSpeler().BerekenWaarde() < 17)
                {
                    spel.GeefHuidigeSpeler().TrekKaart(spel.HuidigeDeck);
                }
                UpdateLabels();
                // Het einde van het spel
                ResultaatScherm eindScherm = new ResultaatScherm();
                // Zet spelers in de lijst van het eindscherm
                foreach (Persoon speler in spel.Spelers)
                {
                    eindScherm.ZetSpelerInLijst(speler.Naam, speler.BerekenWaarde());
                }
                eindScherm.ZetSpelerAlsWinnaar(spel.BepaalWinnaar().Naam);
                if (eindScherm.ShowDialog() == DialogResult.OK)
                {
                    // Herstelt het spel
                    btn_StartSpel.Enabled = true;
                    btn_TrekKaart.Enabled = false;
                    btn_EindigBeurt.Enabled = false;
                    spel.HuidigeSpelerIndex = 0;
                    // Neemt alle kaarten van de spelers weg en geeft ze daarna twee kaarten
                    foreach (var speler in spel.Spelers)
                    {
                        speler.HandDeck = new List<Kaart>();
                        for (int i = 0; i < 2; i++)
                        {
                            speler.TrekKaart(spel.HuidigeDeck);
                        }
                    }
                }
            }
        }

        private void lb_SpelerLijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

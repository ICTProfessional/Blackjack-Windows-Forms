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


        /// <summary>
        /// Zorgt ervoor dat een speler niet meer kaarten kan trekken als hij 21 punten heeft
        /// </summary>
        private void ControleerPunten()
        {
            if (spel.GeefHuidigeSpeler().BerekenWaarde() > 21)
            {
                btn_TrekKaart.Enabled = false;
            }
        }

        private void UpdateSpelerLijst()
        {
            lb_SpelerLijst.Items.Clear();
            foreach (var speler in spel.Spelers)
            {
                lb_SpelerLijst.Items.Add(speler.Naam);
            }
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
            if (spel.Spelers.Count > 1)
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

                ControleerPunten();

            }
            else
            {
                // Foutmelding
                MessageBox.Show("Er zijn geen spelers toegevoegd. Voeg spelers toe door op de knop 'Voeg speler toe' te drukken.", "Kan het spel niet starten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void voegSpelersToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btn_TrekKaart_Click(object sender, EventArgs e)
        {
            // Geeft een kaart aan de speler
            spel.GeefHuidigeSpeler().TrekKaart(spel.HuidigeDeck);
            // Updatet de kaarten label
            UpdateLabels();
            // Schakelt de trek kaart knop uit als de waarde over de 21 is
            ControleerPunten();
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
                var winnaar = spel.BepaalWinnaar();
                if (winnaar == null)
                {
                    eindScherm.ZetSpelerAlsWinnaar("Niemand");
                }
                else
                {
                    eindScherm.ZetSpelerAlsWinnaar(spel.BepaalWinnaar().Naam);
                }
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
                ControleerPunten();
            }
        }

        private void lb_SpelerLijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_VerwijderSpeler_Click(object sender, EventArgs e)
        {
            if (lb_SpelerLijst.SelectedIndex == -1) // Wanneer geen item is geselecteerd
            {
                MessageBox.Show(this, "Je hebt geen speler geselecteerd! Druk op een speler in de lijst.", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Persoon geselecteerdeSpeler = spel.Spelers[lb_SpelerLijst.SelectedIndex];
            if (geselecteerdeSpeler.Naam == "Dealer")
            {
                MessageBox.Show(this, "Je kunt de dealer niet verwijderen!", "Wat doe je nou?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;            
            }
            // Gaat door wanneer alle condities juist zijn
            spel.Spelers.Remove(geselecteerdeSpeler);
            UpdateSpelerLijst();
        }

        private void btn_SpelerToevoegen_Click(object sender, EventArgs e)
        {
            SpelerNaamScherm naamScherm = new SpelerNaamScherm();
            if (naamScherm.ShowDialog(this) == DialogResult.OK)
            {
                string gegevenNaam = naamScherm.GeefNaam();
                // Checkt of de naam van de persoon al aanwezig is
                foreach (var persoon in spel.Spelers)
                {
                    if (persoon.Naam == gegevenNaam)
                    {
                        MessageBox.Show(this, "Er bestaat al een speler met dezelfde naam!", "Doe niet aan identiteitsfraude, aub", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;                    
                    }
                }
                // Voeg persoon toe op het begin van de lijst
                spel.MaakPersoon(naamScherm.GeefNaam(), spel.HuidigeDeck, false);
            }
            UpdateSpelerLijst();
        }

        private void spelregelsTonenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spelregels spelregels = new Spelregels();
            spelregels.ShowDialog();
        }
    }
}

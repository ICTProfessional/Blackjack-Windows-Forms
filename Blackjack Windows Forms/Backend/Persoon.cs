using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Windows_Forms
{
    internal class Persoon
    {
        /// <summary>
        /// De naam van de persoon
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// De kaarten die een persoon bij zich heeft
        /// </summary>
        public List<Kaart> HandDeck { get; set; }

        public Persoon(string _naam, KaartDeck _deck)
        {
            if (_naam.ToLower().Contains("chris") == true) { _naam = "Yoda"; }
            Naam = _naam;
            HandDeck = new List<Kaart>();

            // Elk persoon trekt automatisch twee kaarten
            for (int i = 0; i < 2; i++)
            {
                TrekKaart(_deck);
            }
        }

        /// <summary>
        /// Levert een kaart van de kaartdeck naar de handdeck
        /// </summary>
        public void TrekKaart(KaartDeck _deck)
        {
            Kaart eersteKaart = _deck.KaartenDeck[0];
            // Verandert waarde van aas
            if (eersteKaart.KaartNaam.ToLower().Contains("aas"))
            {
                eersteKaart.KaartWaarde = BerekenAWaarde();
            }
            HandDeck.Add(eersteKaart);
            _deck.KaartenDeck.Remove(eersteKaart);
        }

        
        public int BerekenWaarde()
        {
            int totaleWaarde = 0;
            foreach (Kaart _kaart in HandDeck)
            {
                totaleWaarde += _kaart.KaartWaarde;
            }
            return totaleWaarde;
        }

        public string GeefKaartenAlsString()
        {
            string kaartString = string.Empty;
            // Voegt elke kaartnaam toe
            foreach (var kaart in HandDeck)
            {
                kaartString += $", {kaart.KaartNaam}";
            }
            // Haalt de eerste ', ' weg
            kaartString = kaartString.Remove(0, 2);
            return kaartString;
        }
        /// <summary>
        /// Past de waarde van de aas aan op basis van context
        /// </summary>
        /// <returns></returns>
        public int BerekenAWaarde()
        {
            if (BerekenWaarde() <= 10)
            {
                return 11;
            }
            else
            {
                return 1;
            }
        }
    }
}

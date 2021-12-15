using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Persoon
    {
        /// <summary>
        /// De naam van de speler
        /// </summary>
        public string Naam { get; set; }

        /// <summary>
        /// De kaarten die een persoon bij zich heeft
        /// </summary>
        public List<Kaart> HandDeck { get; set; }

        /// <summary>
        /// Levert een kaart van de kaartdeck naar de handdeck
        /// </summary>
        public void TrekKaart(KaartDeck _deck)
        {
            Random rand = new Random(); // Zorgt voor het maken van willekeurige getallen
            int Kaart = rand.Next(0, _deck.KaartenDeck.Count);
            HandDeck.Add(_deck.KaartenDeck[Kaart]);
            _deck.KaartenDeck.RemoveAt(Kaart);
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
    }
}

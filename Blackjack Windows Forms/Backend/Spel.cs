using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Windows_Forms
{
    internal class Spel
    {
        /// <summary>
        /// De spelers die meedoen aan het spel (inclusief dealer)
        /// </summary>
        public List<Persoon> Spelers { get; set; }
        /// <summary>
        /// De kaartendeck die aanwezig is in het spel
        /// </summary>
        public KaartDeck HuidigeDeck { get; set; }
        /// <summary>
        /// De index van de persoon in de lijst Spelers die aan de beurt is
        /// </summary>
        private int HuidigeSpelerIndex { get; set; }

        public Spel()
        {
            Spelers = new List<Persoon>();
            HuidigeDeck = new KaartDeck();
            HuidigeSpelerIndex = 0;
        }

        public void MaakNieuweDeck()
        {
            HuidigeDeck = new KaartDeck();
        }

        public Persoon GeefHuidigeSpeler()
        {
            return Spelers[HuidigeSpelerIndex];
        }

        public void WisselHuidigPersoon()
        {
            HuidigeSpelerIndex += 1;
            if (HuidigeSpelerIndex > Spelers.Count())
            {
                HuidigeSpelerIndex = 0;
            }
        }

        /// <summary>
        /// Vraagt voor een aantal personen en stopt deze in de lijst Spelers
        /// </summary>
        public void MaakPersoon(string _naam, KaartDeck _deck)
        {
            Spelers.Add(new Persoon(_naam, _deck));
        }
    }
}

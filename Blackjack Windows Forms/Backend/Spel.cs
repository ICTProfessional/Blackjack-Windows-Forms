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
        public int HuidigeSpelerIndex { get; set; }

        public Spel()
        {
            Spelers = new List<Persoon>();
            HuidigeDeck = new KaartDeck();
            MaakPersoon("Dealer", HuidigeDeck, true);
            HuidigeSpelerIndex = 0;
        }

        /// <summary>
        /// Hervult de deck
        /// </summary>
        public void MaakNieuweDeck()
        {
            HuidigeDeck = new KaartDeck();
        }

        /// <summary>
        /// Geeft de gegevens van de huidige speler die aan de beurt is.
        /// </summary>
        /// <returns></returns>
        public Persoon GeefHuidigeSpeler()
        {
            return Spelers[HuidigeSpelerIndex];
        }

        /// <summary>
        /// De huidige speler index wordt met een verhoogd
        /// </summary>
        public void WisselHuidigPersoon()
        {
            HuidigeSpelerIndex += 1;
            if (HuidigeSpelerIndex > Spelers.Count())
            {
                HuidigeSpelerIndex = 0;
            }
        }

        /// <summary>
        /// Vraagt voor een naam en stopt deze in de lijst Spelers. Speler trekt twee kaarten uit _deck
        /// Als _isDealer false is, wordt de persoon op het begin van de lijst toegevoegd
        /// </summary>
        public void MaakPersoon(string _naam, KaartDeck _deck, bool _isDealer)
        {
            if (_isDealer)
            {
                Spelers.Add(new Persoon(_naam, _deck));
            }
            else
            {
                Spelers.Insert(0, new Persoon(_naam, _deck));
            }
        }

        /// <summary>
        /// Bepaalt welke speler heeft gewonnen van Blackjack
        /// </summary>
        /// <returns></returns>
        public Persoon BepaalWinnaar()
        {
            List<Persoon> mogelijkeWinnaars = Spelers.ToList();
            // Haalt de spelers weg die over de 21 zijn belandt
            foreach (var speler in Spelers)
            {
                if (speler.BerekenWaarde() > 21)
                {
                    mogelijkeWinnaars.Remove(speler);
                }
            }

            if (mogelijkeWinnaars.Count == 0)
            {
                return null;
            }

            // Pikt een persoon en haalt degenen weg die lager zijn dan hem.
            Persoon gekozenPersoon = mogelijkeWinnaars[0];
            // Hij doet dit zo lang tot er een mogelijke winnaar overblijft
            while (mogelijkeWinnaars.Count > 1)
            {
                foreach (var speler in Spelers)
                {
                    if (mogelijkeWinnaars.Contains(speler))
                    {
                        if (speler.BerekenWaarde() < gekozenPersoon.BerekenWaarde())
                        {
                            mogelijkeWinnaars.Remove(speler);
                        }
                        else if (gekozenPersoon.BerekenWaarde() < speler.BerekenWaarde())
                        {
                            mogelijkeWinnaars.Remove(gekozenPersoon);
                            gekozenPersoon = speler;
                        }
                        else if (gekozenPersoon.Naam != speler.Naam)
                        {
                            mogelijkeWinnaars.Remove(speler);
                        }
                    }
                }
            }
            return mogelijkeWinnaars[0];
        }
    }
}

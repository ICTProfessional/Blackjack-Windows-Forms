using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack_Windows_Forms
{
    class KaartDeck
    {
        /// <summary>
        /// Dit is de lijst met kaarten
        /// </summary>
        public List<Kaart> KaartenDeck = new List<Kaart>();
        /// <summary>
        /// Hier worden alle 52 kaarten gemaakt
        /// </summary>
        public void MaakKaarten()
        {
            KaartenDeck.Add(new Kaart("Harten 2", 2));
            KaartenDeck.Add(new Kaart("Harten 3", 3));
            KaartenDeck.Add(new Kaart("Harten 4", 4));
            KaartenDeck.Add(new Kaart("Harten 5", 5));
            KaartenDeck.Add(new Kaart("Harten 6", 6));
            KaartenDeck.Add(new Kaart("Harten 7", 7));
            KaartenDeck.Add(new Kaart("Harten 8", 8));
            KaartenDeck.Add(new Kaart("Harten 9", 9));
            KaartenDeck.Add(new Kaart("Harten 10", 10));
            KaartenDeck.Add(new Kaart("Harten Boer", 10));
            KaartenDeck.Add(new Kaart("Harten Vrouw", 10));
            KaartenDeck.Add(new Kaart("Harten Koning", 10));
            KaartenDeck.Add(new Kaart("Harten Aas", 11));

            KaartenDeck.Add(new Kaart("Schoppen 2", 2));
            KaartenDeck.Add(new Kaart("Schoppen 3", 3));
            KaartenDeck.Add(new Kaart("Schoppen 4", 4));
            KaartenDeck.Add(new Kaart("Schoppen 5", 5));
            KaartenDeck.Add(new Kaart("Schoppen 6", 6));
            KaartenDeck.Add(new Kaart("Schoppen 7", 7));
            KaartenDeck.Add(new Kaart("Schoppen 8", 8));
            KaartenDeck.Add(new Kaart("Schoppen 9", 9));
            KaartenDeck.Add(new Kaart("Schoppen 10", 10));
            KaartenDeck.Add(new Kaart("Schoppen Boer", 10));
            KaartenDeck.Add(new Kaart("Schoppen Vrouw", 10));
            KaartenDeck.Add(new Kaart("Schoppen Koning", 10));
            KaartenDeck.Add(new Kaart("Schoppen Aas", 11));

            KaartenDeck.Add(new Kaart("Ruiten 2", 2));
            KaartenDeck.Add(new Kaart("Ruiten 3", 3));
            KaartenDeck.Add(new Kaart("Ruiten 4", 4));
            KaartenDeck.Add(new Kaart("Ruiten 5", 5));
            KaartenDeck.Add(new Kaart("Ruiten 6", 6));
            KaartenDeck.Add(new Kaart("Ruiten 7", 7));
            KaartenDeck.Add(new Kaart("Ruiten 8", 8));
            KaartenDeck.Add(new Kaart("Ruiten 9", 9));
            KaartenDeck.Add(new Kaart("Ruiten 10", 10));
            KaartenDeck.Add(new Kaart("Ruiten Boer", 10));
            KaartenDeck.Add(new Kaart("Ruiten Vrouw", 10));
            KaartenDeck.Add(new Kaart("Ruiten Koning", 10));
            KaartenDeck.Add(new Kaart("Ruiten Aas", 11));

            KaartenDeck.Add(new Kaart("Klaveren 2", 2));
            KaartenDeck.Add(new Kaart("Klaveren 3", 3));
            KaartenDeck.Add(new Kaart("Klaveren 4", 4));
            KaartenDeck.Add(new Kaart("Klaveren 5", 5));
            KaartenDeck.Add(new Kaart("Klaveren 6", 6));
            KaartenDeck.Add(new Kaart("Klaveren 7", 7));
            KaartenDeck.Add(new Kaart("Klaveren 8", 8));
            KaartenDeck.Add(new Kaart("Klaveren 9", 9));
            KaartenDeck.Add(new Kaart("Klaveren 10", 10));
            KaartenDeck.Add(new Kaart("Klaveren Boer", 10));
            KaartenDeck.Add(new Kaart("Klaveren Vrouw", 10));
            KaartenDeck.Add(new Kaart("Klaveren Koning", 10));
            KaartenDeck.Add(new Kaart("Klaveren Aas", 11));
        }
        /// <summary>
        /// Hier worden de kaarten geschud
        /// </summary>
        public void Schudden()
        {
            var rnd = new Random();
            var randomKaartenDeck = KaartenDeck.OrderBy(item => rnd.Next());
            KaartenDeck = (List<Kaart>)randomKaartenDeck;
        }
    }
}

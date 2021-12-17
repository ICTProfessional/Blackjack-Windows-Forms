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
            string[] kleuren = new string[] { "Harten", "Klaveren", "Ruiten", "Schoppen" };

            foreach (string k in kleuren) {
                KaartenDeck.Add(new Kaart(k + " 2", 2));
                KaartenDeck.Add(new Kaart(k + " 3", 3));
                KaartenDeck.Add(new Kaart(k + " 4", 4));
                KaartenDeck.Add(new Kaart(k + " 5", 5));
                KaartenDeck.Add(new Kaart(k + " 6", 6));
                KaartenDeck.Add(new Kaart(k + " 7", 7));
                KaartenDeck.Add(new Kaart(k + " 8", 8));
                KaartenDeck.Add(new Kaart(k + " 9", 9));
                KaartenDeck.Add(new Kaart(k + " 10", 10));
                KaartenDeck.Add(new Kaart(k + " Boer", 10));
                KaartenDeck.Add(new Kaart(k + " Vrouw", 10));
                KaartenDeck.Add(new Kaart(k + " Koning", 10));
                KaartenDeck.Add(new Kaart(k + " Aas", 11));

            }
        }

        public KaartDeck()
        {
            MaakKaarten();
            Schudden();
        }

        /// <summary>
        /// Hier worden de kaarten geschud
        /// </summary>
        public void Schudden()
        {
            var rnd = new Random();
            for (int i = 0; i < 9000; i++)
            {
                var randKaart = KaartenDeck[rnd.Next(0, KaartenDeck.Count())];
                KaartenDeck.Remove(randKaart);
                KaartenDeck.Insert(0, randKaart);
            }
        }
    }
}

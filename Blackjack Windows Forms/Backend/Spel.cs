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
        /// De spelers die meedoen aan het spel
        /// </summary>
        public List<Speler> Spelers { get; set; }
        /// <summary>
        /// De dealer die meedoet aan het spel
        /// </summary>
        public Persoon Dealer { get; set; }
        /// <summary>
        /// De kaartendeck die aanwezig is in het spel
        /// </summary>
        public KaartDeck HuidigeDeck { get; set; }

        public void MaakNieuweDeck()
        {
            HuidigeDeck = new KaartDeck();
        }

        /// <summary>
        /// Vraagt voor een aantal personen en stopt deze in de lijst Spelers
        /// </summary>
        public void MaakPersonen()
        {
            // Vraagt om aantal personen
            Console.WriteLine("Hoeveel spelers spelen mee?: ");

            // Haalt alle spelers uit lijst Spelers weg
            Spelers = new List<Speler>();

            char invoer = Console.ReadKey().KeyChar;
            int hoeveelheidSpelers = invoer - '0';

            // Voegt personen toe aan lijst Spelers
            for (int i = 1; i <= hoeveelheidSpelers; i++)
            {
                Console.WriteLine($"Hoe heet speler {i}?: ");
                Spelers.Add(new Speler(Console.ReadLine()));
            }
            
        }
    }
}

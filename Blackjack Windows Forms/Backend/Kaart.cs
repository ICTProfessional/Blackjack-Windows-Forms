using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Windows_Forms
{
    internal class Kaart
    {
        /// <summary>
        /// De naam van de kaart
        /// </summary>
        public string KaartNaam { get; set; }
        /// <summary>
        /// De waarde van de kaart tussen de 1 en de 11
        /// </summary>
        public int KaartWaarde { get; set; }

        public Kaart(string _naam, int _waarde)
        {
            KaartNaam = _naam;
            KaartWaarde = _waarde;
        }
    }
}

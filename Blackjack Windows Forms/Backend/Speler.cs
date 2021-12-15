using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_Windows_Forms
{
    internal class Speler : Persoon
    {
        /// <summary>
        /// Het geld die een speler heeft ingezet
        /// </summary>
        public float Pot { get; set; }

        public Speler(string _naam)
        {
            Naam = _naam;
        }
    }
}

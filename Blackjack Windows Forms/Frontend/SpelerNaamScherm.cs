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
    public partial class SpelerNaamScherm : Form
    {

        public string GeefNaam()
        {
            if (txt_SpelerNaam.Text == "Dealer")
            {
                return "DeaIer";
            }
            return txt_SpelerNaam.Text;
        }
        public SpelerNaamScherm(int _spelerRang)
        {
            InitializeComponent();
            // Geeft aan welke speler op dat moment de naam krijgt
            lbl_SpelerNaam.Text = lbl_SpelerNaam.Text.Replace("<int>", _spelerRang.ToString());
        }
    }
}

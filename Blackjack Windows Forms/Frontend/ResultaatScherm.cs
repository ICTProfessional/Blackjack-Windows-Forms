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
    public partial class ResultaatScherm : Form
    {

        public void ZetSpelerInLijst(string _naam, int _waarde)
        {
            lb_PlayerData.Items.Add($"{_naam} | {_waarde}");
        }

        public void ZetSpelerAlsWinnaar(string _naam)
        {
            lbl_WinnaarNaam.Text = $"{_naam} is de winnaar!";
        }

        public ResultaatScherm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class VoegSpelerToeScherm : Form
    {
        public VoegSpelerToeScherm()
        {
            InitializeComponent();
        }

        public int GeefSpelerAantal()
        {
            return (int) num_AantalSpelers.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

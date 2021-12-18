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
        public SpelerNaamScherm()
        {
            InitializeComponent();
        }

        private void SpelerNaamScherm_Load(object sender, EventArgs e)
        {

        }
    }
}

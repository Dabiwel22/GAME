using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSkaro : Form
    {
        bool Skaro = false;
        bool Earth = false;
        bool Galifrey = false;
        bool Davros = false; 
        public frmSkaro()
        {
            InitializeComponent();
        }

        private void btnSkaro_Click(object sender, EventArgs e)
        {
            Skaro = true;
            btnSkaro.Visible = false;
            MessageBox.Show ("the timelords found you and imprisoned you for stealling the T.A.R.D.I.S.");
        }

        private void btnDavros_Click(object sender, EventArgs e)
        {
            Davros = true;
            btnDavros.Visible = false;
            MessageBox.Show("How did you find Davros you aren't on Skaro yet.");
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            Galifrey = true;
            btnGalifrey.Visible = false;
            MessageBox.Show("Find the T.A.R.D.I.S");
        }

        private void btnGalifrey_Click(object sender, EventArgs e)
        {
            Earth = true;
            btnEarth.Visible = false;
            MessageBox.Show("Find Clara");
        }
    }
}

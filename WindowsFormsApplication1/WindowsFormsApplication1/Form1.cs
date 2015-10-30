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

        }

        private void btnEarth_Click(object sender, EventArgs e)
        {

        }

        private void btnGalifrey_Click(object sender, EventArgs e)
        {

        }
    }
}

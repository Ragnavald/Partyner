using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace Forms
{
    public partial class Sobre : MetroForm
    {
        public Sobre()
        {
            InitializeComponent();
        }

        int alternar = -1;

        private void btnEULA_Click(object sender, EventArgs e)
        {
            alternar *= -1;
            if (alternar == 1)
            {
                pictureBox1.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                txtEULA.Visible = true;
                btnEULA.Text = "Detalhes";
            }
            else 
            {
                pictureBox1.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                txtEULA.Visible = false;
                btnEULA.Text = "Termos de uso";
            }
        }
    }
}

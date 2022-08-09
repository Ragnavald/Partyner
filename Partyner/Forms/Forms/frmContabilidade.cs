using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Classes;

namespace Forms
{
    public partial class frmContabilidade : MetroForm
    {
        public frmContabilidade()
        {
            InitializeComponent();
        }

        int alternar = 1;

        private void CarregarCrtEvento()
        {
            for (int i = 0; i < con.ShowLucros().Rows.Count; i++)
            {
                DateTime data = (DateTime)con.ShowLucros().Rows[i]["Data_evento"];
                crtEvento.Series["Lucros"].Points.AddXY(data.ToString("d/M/yyyy"), con.ShowLucros().Rows[i]["valor total"]);
                double teste = 0;
            }
        }

        Conexao con = new Conexao();

        private void frmContabilidade_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            for (int i = 1; i < con.ShowLucros().Rows.Count; i++)
            {
                con.CalcularLucro(i);
            }

            if (con.ShowLucros().Rows.Count > 0)
            {
                CarregarCrtEvento();
            }
            else
            {
                crtEvento.Series["Lucros"].Points.Clear();
            }

            dgvLucros.DataSource = con.showcont();
        }

        private void frmContabilidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnAlternar_Click(object sender, EventArgs e)
        {
            alternar *= -1;
            if (alternar > 0)
            {
                btnAlternar.Text = "Menos Detalhes";
                dgvLucros.Visible = false;
                crtEvento.Visible = true;
            }
            else 
            {
                btnAlternar.Text = "Mais Detalhes";
                dgvLucros.Visible = true;
                crtEvento.Visible = false;
            }
        }
    }
}

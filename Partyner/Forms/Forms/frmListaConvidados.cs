using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Classes;

namespace Forms
{
    public partial class frmListaConvidados : MetroForm
    {
        public frmListaConvidados()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idConvidados = null;
        string idConvidadosPresentes = null;
        string evento;

        private void frmListaConvidados_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            cmbEvento.DataSource = con.ShowEvento();
            cmbEvento.DisplayMember = "descrição";
            cmbEvento.ValueMember = "id";
            cmbEvento.SelectedIndex = -1;
        }

        private void frmListaConvidados_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnCarregarEvento_Click(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedIndex != -1)
            {
                evento = cmbEvento.SelectedValue.ToString();
                dgvConvidados.DataSource = con.ListConvidados(evento);
                dgvConvidadosPresentes.DataSource = con.ListConvidadosPresentes(evento);
            }
        }

        private void dgvConvidados_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvConvidados.CurrentRow != null)
            {
                idConvidados = dgvConvidados.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void dgvConvidadosPresentes_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvConvidadosPresentes.CurrentRow != null)
            {
                idConvidadosPresentes = dgvConvidadosPresentes.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnCarregarPresenca_Click(object sender, EventArgs e)
        {
            con.RegistrarPresenca(idConvidados);
            dgvConvidados.DataSource = con.ListConvidados(evento);
            dgvConvidadosPresentes.DataSource = con.ListConvidadosPresentes(evento);
        }

        private void btnDesfazerPresenca_Click(object sender, EventArgs e)
        {
            con.DesfazerPresenca(idConvidadosPresentes);
            dgvConvidados.DataSource = con.ListConvidados(evento);
            dgvConvidadosPresentes.DataSource = con.ListConvidadosPresentes(evento);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvConvidados.DataSource = con.ListConvidadosPesquisa(evento, pesquisa);
        }

        private void btnPesquisarPresente_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaPresente.Text;
            dgvConvidadosPresentes.DataSource = con.ListConvidadosPresentesPesquisa(evento, pesquisa);
        }
    }
}

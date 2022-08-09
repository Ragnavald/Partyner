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
using MetroFramework.Animation;
using Classes;
using Forms;

namespace Forms 
{
    public partial class frmTipos : MetroForm
    {
        public frmTipos()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idTipo = null;
            txtNomeTipo.Clear();
            txtPrecoTipo.Clear();
            selecionado = false;
        }

        Conexao con = new Conexao();

        string idTipo;
        bool selecionado = false;
        int tCont = 0;
        Admin user = Usuario.UsuarioAtual[0];


        private void frmTipos_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvTipos.DataSource = con.ShowTipos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    double preco;
                    if (double.TryParse(txtPrecoTipo.Text, out preco))
                    {
                        Tipo tipo = new Tipo(txtNomeTipo.Text,preco);
                        if (con.CadTipos(tipo))
                        {
                            MoveAnimation mexer = new MoveAnimation();
                            lblAlerta.Text = "Sucesso ao cadastrar";
                            Point ponto = new Point(23, 199);
                            lblAlerta.Visible = true;
                            mexer.Start(mpAlerta, ponto, TransitionType.Linear, 15);
                            tAlerta.Enabled = true;
                            Limpar();
                        }
                        else 
                        {
                            Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a inserção dos dados.");
                            msg.Show();
                        }
                    }
                    else 
                    {
                        Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira números em Preço");
                        msg.Show();
                    }
                }
                else 
                {
                    Limpar();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
            dgvTipos.DataSource = con.ShowTipos();
            Limpar();
        }

        private void dgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipos.CurrentRow != null) 
            {
                idTipo = dgvTipos.CurrentRow.Cells[0].Value.ToString();
                txtNomeTipo.Text = dgvTipos.CurrentRow.Cells["nome"].Value.ToString();
                txtPrecoTipo.Text = dgvTipos.CurrentRow.Cells["preco"].Value.ToString();

                btnCadastrar.Text = "Cancelar";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionado = true;
            }
        }

        private void frmTipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            double preco;
            if (double.TryParse(txtPrecoTipo.Text, out preco))
            {
                Tipo tipo = new Tipo(txtNomeTipo.Text, preco, idTipo);
                if (con.UpTipos(tipo))
                {
                    lblAlerta.Text = "Sucesso ao Editar Tipo";
                    lblAlerta.Visible = true;
                    tAlerta.Enabled = true;
                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira números em Preço");
                    msg.Show();
                }
            }
            dgvTipos.DataSource = con.ShowTipos();
            Limpar();
        
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                if (con.DelTipos(idTipo))
                {
                    lblAlerta.Text = "Sucesso ao Excluir Cliente";
                    lblAlerta.Visible = true;
                    tAlerta.Enabled = true;
                }
                else 
                {
                    Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.\nTente antes excluir os outros dados vinculados a este evento.");
                    msgn.ShowDialog();
                }
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
            dgvTipos.DataSource = con.ShowTipos();
        }

        private void tAlerta_Tick(object sender, EventArgs e)
        {
            if (tCont >= 5)
            {
                lblAlerta.Visible = false;
                tAlerta.Enabled = false;
                tCont = 0;
            }
            else
            {
                tCont++;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvTipos.DataSource = con.PesquisaTipos(pesquisa, cmbTipoPesquisa.SelectedIndex);
        }
    }
}

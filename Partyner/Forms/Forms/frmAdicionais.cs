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
    public partial class frmAdicionais : MetroForm
    {
        public frmAdicionais()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idAdicional;
        bool selecionado = false;
        int tCont = 0;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idAdicional = null;
            txtNomeAdic.Clear();
            txtPrecoAdic.Clear();
            selecionado = false;
        }

        private void frmAdicionais_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvAdicionais.DataSource = con.ShowAdicionais();

            for (int i = 0; i < dgvAdicionais.Columns.Count; i++)
            {
                DataGridViewColumn tamanhoColuna = dgvAdicionais.Columns[i];
                tamanhoColuna.Width = 200;

            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    double preco;
                    if (double.TryParse(txtPrecoAdic.Text, out preco))
                    {
                        Adicionais ad = new Adicionais(txtNomeAdic.Text, preco);
                        if (con.CadAdicionais(ad))
                        {
                            MoveAnimation mexer = new MoveAnimation();
                            lblAlerta.Text = "Sucesso ao cadastrar";
                            Point ponto = new Point(23, 198);
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

                }
            }
            catch (Exception error)
            {
                throw error;
            }
            dgvAdicionais.DataSource = con.ShowAdicionais();
            Limpar();
        }

        private void dgvAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvAdicionais.CurrentRow != null)
            {
                idAdicional = dgvAdicionais.CurrentRow.Cells[0].Value.ToString();
                txtNomeAdic.Text = dgvAdicionais.CurrentRow.Cells[1].Value.ToString();
                txtPrecoAdic.Text = dgvAdicionais.CurrentRow.Cells[2].Value.ToString();

                btnCadastrar.Text = "Cancelar";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionado = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                Mensagem msgConfirmar = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                msgConfirmar.ShowDialog();
                if (msgConfirmar.Resposta)
                {
                    if (con.DelAdicionais(idAdicional))
                    {
                        Limpar();
                    }
                    else
                    {
                        Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão de dados.");
                        msg.Show();
                    }
                }
            }
            else
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
            dgvAdicionais.DataSource = con.ShowAdicionais();
        }

        private void frmAdicionais_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            double preco;
            if (double.TryParse(txtPrecoAdic.Text, out preco))
            {
                Adicionais ad = new Adicionais(txtNomeAdic.Text, preco, idAdicional);
                if (con.UpAdicionais(ad))
                {

                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a edição de dados.");
                    msg.Show();
                }
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira números em Preço");
                msg.Show();
            }
            dgvAdicionais.DataSource = con.ShowAdicionais();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvAdicionais.DataSource = con.PesquisaAdicionais(pesquisa, cmbTipoPesquisa.SelectedIndex);
        }

        private void tAlerta_Tick(object sender, EventArgs e)
        {
            if (tCont >= 2)
            {
                MoveAnimation mexer = new MoveAnimation();
                Point ponto = new Point(23, 175);
                tAlerta.Enabled = false;
                mexer.Start(mpAlerta, ponto, TransitionType.Linear, 15);
                tCont = 0;
            }
            else
            {
                tCont++;
            }
        }
    }
}

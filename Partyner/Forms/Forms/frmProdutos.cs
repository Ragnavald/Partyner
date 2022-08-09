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

namespace Forms
{
    public partial class frmProdutos : MetroForm
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        string idProduto;
        bool selecionado = false;
        int tCont = 0;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idProduto = null;
            txtNomeProd.Clear();
            txtPrecoProd.Clear();
            txtCategoria.Clear();
            selecionado = false;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvProdutos.DataSource = con.ShowProdutos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    double preco;
                    if (double.TryParse(txtPrecoProd.Text, out preco))
                    {
                        Produtos prod = new Produtos(txtNomeProd.Text, txtCategoria.Text, preco);
                        if (con.CadProdutos(prod))
                        {
                            MoveAnimation mexer = new MoveAnimation();
                            lblAlerta.Text = "Sucesso ao cadastrar";
                            Point ponto = new Point(23, 239);
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
            dgvProdutos.DataSource = con.ShowProdutos();
        }

        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            double preco;
            if (double.TryParse(txtPrecoProd.Text, out preco))
            {
                Produtos prod = new Produtos(txtNomeProd.Text, txtCategoria.Text, preco, idProduto);
                if (con.UpProdutos(prod))
                {
                    lblAlerta.Text = "Sucesso ao Editar Produto";
                    lblAlerta.Visible = true;
                    tAlerta.Enabled = true;
                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a edição dos dados.");
                    msg.Show();
                }
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira números em Preço");
                msg.Show();
            }
            dgvProdutos.DataSource = con.ShowProdutos();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                msg.ShowDialog();
                if (msg.Resposta)
                {
                    if (con.DelProdutos(idProduto))
                    {
                        lblAlerta.Text = "Sucesso ao Excluir Produto";
                        lblAlerta.Visible = true;
                        tAlerta.Enabled = true;
                    }
                    else
                    {
                        Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.");
                        msgn.ShowDialog();
                    }
                }
            }
            else
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
            dgvProdutos.DataSource = con.ShowProdutos();
            Limpar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                idProduto = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtNomeProd.Text = dgvProdutos.CurrentRow.Cells["nome"].Value.ToString();
                txtCategoria.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                txtPrecoProd.Text = dgvProdutos.CurrentRow.Cells["preco"].Value.ToString();

                btnCadastrar.Text = "Cancelar";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionado = true;
            }
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
    }
}

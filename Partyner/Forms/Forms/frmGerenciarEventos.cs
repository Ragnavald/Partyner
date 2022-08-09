using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Animation;
using Classes;

namespace Forms
{
    public partial class frmGerenciarEventos : MetroForm
    {
        public frmGerenciarEventos()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idEvento;
        string idProd;
        string idFunc;
        int tCont;
        bool selecionadoFunc = false;
        bool selecionadoProd = false;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar() 
        {
            idProd = null;
            idFunc = null;
            idEvento = null;
            btnProdutos.Text = "Adicionar";
            btnFuncionarios.Text = "Adicionar";
            cmbFuncionarios.Enabled = false;
            cmbProdutos.Enabled = false;
            btnProdutos.Enabled = false;
            btnFuncionarios.Enabled = false;
            dgvFuncionarios.DataSource = DataTableClearEventArgs.Empty;
            dgvProdutos.DataSource = DataTableClearEventArgs.Empty;
            selecionadoFunc = false;
            selecionadoProd = false;
            txtQTD.Clear();
            txtQTD.Enabled = false;
            txtPagamento.Clear();
            txtPagamento.Enabled = false;
        }

        private void frmGerenciarEventos_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvEventos.DataSource = con.ShowEvento();

            cmbFuncionarios.DataSource = con.ShowFuncionario();
            cmbFuncionarios.DisplayMember = "nome";
            cmbFuncionarios.ValueMember = "id_funcionario";

            cmbProdutos.DataSource = con.ShowProdutos();
            cmbProdutos.DisplayMember = "nome";
            cmbProdutos.ValueMember = "id_produto";
        }

        private void frmGerenciarEventos_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void dgvEventos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (dgvEventos.CurrentRow != null) 
            {
                idEvento = dgvEventos.CurrentRow.Cells[0].Value.ToString();

                cmbFuncionarios.Enabled = true;
                btnFuncionarios.Enabled = true;
                cmbProdutos.Enabled = true;
                btnProdutos.Enabled = true;
                txtQTD.Enabled = true;
                txtPagamento.Enabled = true;

                dgvFuncionarios.DataSource = con.ShowFuncEvento(idEvento);
                dgvProdutos.DataSource = con.ShowProdEventos(idEvento);
            }
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            if (!selecionadoFunc)
            {
                double pagamento;
                if (double.TryParse(txtPagamento.Text, out pagamento))
                {
                    if (con.CadFuncEvento(cmbFuncionarios.SelectedValue.ToString(), double.Parse(txtPagamento.Text), idEvento))
                    {
                        MoveAnimation mexer = new MoveAnimation();
                        lblFunc.Text = "Sucesso ao cadastrar";
                        Point ponto = new Point(23, 238);
                        lblFunc.Visible = true;
                        mexer.Start(mpFunc, ponto, TransitionType.Linear, 15);
                        tAlerta.Enabled = true;
                    }
                    else
                    {
                        Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a inserção dos dados.");
                        msg.Show();
                    }
                }
                else 
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Insira apenas números");
                    msg.Show();
                }
            }
            else 
            {
                if (user.IsAdmin)
                {
                    Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                    msg.ShowDialog();

                    if (msg.Resposta)
                    {
                        if (!con.DelFuncEvento(idFunc))
                        {
                            Mensagem msgerror = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a Exclusão dos dados.");
                            msgerror.Show();
                        }
                        Limpar();
                    }
                }
            }
            dgvFuncionarios.DataSource = con.ShowFuncEvento(idEvento);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (!selecionadoProd)
            {
                int QTD;
                if (int.TryParse(txtQTD.Text, out QTD))
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a inserção dos dados.");
                    if (txtQTD.Text != "")
                    {
                        if (con.CadProdEventos(cmbProdutos.SelectedValue.ToString(), idEvento, int.Parse(txtQTD.Text)))
                        {
                            MoveAnimation mexer = new MoveAnimation();
                            lblProd.Text = "Sucesso ao cadastrar";
                            Point ponto = new Point(25, 475);
                            lblProd.Visible = true;
                            mexer.Start(mpProd, ponto, TransitionType.Linear, 15);
                            tAlerta.Enabled = true;
                        }
                        else
                        {
                            msg.Show();
                        }
                    }
                }
                else 
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Insira apenas números");
                    msg.Show();
                }
            }
            else 
            {
                if (user.IsAdmin)
                {
                    Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                    msg.ShowDialog();

                    if (msg.Resposta)
                    {
                        if (!con.DelProdEvento(idProd))
                        {
                            Mensagem msgerror = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a Exclusão dos dados.");
                            msgerror.Show();
                        }
                        Limpar();
                    }
                }
                else 
                {
                    Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                    msg.ShowDialog();
                }
            }
            dgvProdutos.DataSource = con.ShowProdEventos(idEvento);
        }

        private void dgvProdutos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            selecionadoFunc = false;
            selecionadoProd = true;
            idProd = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
            btnProdutos.Text = "Excluir";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvFuncionarios_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            selecionadoFunc = true;
            selecionadoProd = false;
            idFunc = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
            btnFuncionarios.Text = "Excluir";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvEventos.DataSource = con.PesquisaEvento(cmbTipoPesquisa.SelectedIndex, pesquisa);
        }

        private void tAlerta_Tick(object sender, EventArgs e)
        {
            if (tCont >= 2)
            {
                MoveAnimation mexerfunc = new MoveAnimation();
                MoveAnimation mexerprod = new MoveAnimation();
                Point pontofunc = new Point(23, 214);
                Point pontoprod = new Point(25, 451);
                tAlerta.Enabled = false;
                mexerfunc.Start(mpFunc, pontofunc, TransitionType.Linear, 15);
                mexerprod.Start(mpProd, pontoprod, TransitionType.Linear, 15);
                tCont = 0;
            }
            else
            {
                tCont++;
            }
        }
    }
}

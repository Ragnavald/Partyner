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
    public partial class frmEventos : MetroForm
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idEvento;
        bool selecionado = false;
        bool selecionadoAdicional = false;
        int tCont = 0;
        string idAdicional;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idEvento = null;
            txtDescricao.Clear();
            txtNMC.Clear();
            selecionado = false;

            cmbAdicionais.Enabled = false;
            btnAdicionais.Enabled = false;
            dgvAdicionais.Enabled = false;
            dgvAdicionais.DataSource = DataTableClearEventArgs.Empty;
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            Conexao con = new Conexao();

            dgvConsultaEven.DataSource = con.ShowEvento();
            dgvConsultaEven.Columns["IdCliente"].Visible = false;
            dgvConsultaEven.Columns["id_tipo"].Visible = false;

            cmbTipo.DataSource = con.ShowTipos();
            cmbTipo.DisplayMember = "nome";
            cmbTipo.ValueMember = "id_tipo";

            cmbCliente.DataSource = con.ShowClientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";

            cmbAdicionais.DataSource = con.ShowAdicionais();
            cmbAdicionais.DisplayMember = "nome";
            cmbAdicionais.ValueMember = "id_adicional";

            for (int i = 0; i < dgvConsultaEven.Columns.Count; i++)
            {
                DataGridViewColumn tamanhoColuna = dgvConsultaEven.Columns[i];
                tamanhoColuna.Width = 156;
            }
        }

        private void frmEventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void dgvConsultaEven_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaEven.CurrentRow != null)
            {
                idEvento = dgvConsultaEven.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvConsultaEven.CurrentRow.Cells["Descrição"].Value.ToString();
                dtpData.Value = (DateTime)dgvConsultaEven.CurrentRow.Cells["Data do Evento"].Value;
                cmbCliente.SelectedValue = dgvConsultaEven.CurrentRow.Cells["IdCliente"].Value;
                txtNMC.Text = dgvConsultaEven.CurrentRow.Cells["Qtd de convidados"].Value.ToString();
                cmbTipo.SelectedValue = dgvConsultaEven.CurrentRow.Cells["id_tipo"].Value;
                dgvAdicionais.DataSource = con.ShowAdEvento(idEvento);
                dgvAdicionais.Columns["Id"].Visible = false;

                cmbAdicionais.Enabled = true;
                btnAdicionais.Enabled = true;
                dgvAdicionais.Enabled = true;

                btnCadastrar.Text = "Cancelar";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionado = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    if (cmbCliente.SelectedIndex == -1 || txtDescricao.Text == "" || txtNMC.Text == "" || cmbTipo.SelectedIndex == -1)
                    {
                        Mensagem msg = new Mensagem("", "OK", "Campos vazios", "Por favor, preencha todos os campos.");
                        msg.ShowDialog();
                    }
                    else
                    {
                        int nmc;
                        if (int.TryParse(txtNMC.Text, out nmc) && nmc > 0)
                        {
                            string descricao = txtDescricao.Text;
                            Evento eve = new Evento(descricao, dtpData.Value.Date, cmbTipo.SelectedValue.ToString(), nmc, cmbCliente.SelectedValue.ToString());
                            if (con.CadEventos(eve))
                            {
                                MoveAnimation mexer = new MoveAnimation();
                                lblAlerta.Text = "Sucesso ao cadastrar";
                                Point ponto = new Point(24, 635);
                                lblAlerta.Visible = true;
                                mexer.Start(mpAlerta, ponto, TransitionType.Linear, 15);
                                tAlerta.Enabled = true;
                                Limpar();
                            }
                            else
                            {
                                Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a inserção dos dados.");
                                msg.ShowDialog();
                            }
                        }
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
            dgvConsultaEven.DataSource = con.ShowEvento();
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

        private void btnAdicionais_Click(object sender, EventArgs e)
        {
            if (!selecionadoAdicional)
            {
                if (cmbAdicionais.SelectedIndex == -1)
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor Um adicional");
                    msg.Show();
                }
                else
                {
                    if (con.CadAdEvento(cmbAdicionais.SelectedValue.ToString(), idEvento))
                    {
                        dgvAdicionais.DataSource = con.ShowAdEvento(idEvento);
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
                Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja\nexcluir esse registro?");
                msg.ShowDialog();
                if (msg.Resposta)
                {
                    if (!con.DelAdEvento(idAdicional, idEvento))
                    {
                        Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.");
                        msgn.ShowDialog();
                    }
                }
                btnAdicionais.Text = "Adicionar";
                selecionadoAdicional = false;
            }
            dgvAdicionais.DataSource = con.ShowAdEvento(idEvento);
            dgvConsultaEven.DataSource = con.ShowEvento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || txtDescricao.Text == "" || txtNMC.Text == "" || cmbTipo.SelectedIndex == -1)
            {
                Mensagem msg = new Mensagem("", "OK", "Campos vazios", "Por favor, preencha todos os campos.");
                msg.ShowDialog();
            }
            else
            {
                string descricao = txtDescricao.Text;
                Evento eve = new Evento(idEvento, descricao, dtpData.Value.Date, cmbTipo.SelectedValue.ToString(), int.Parse(txtNMC.Text), cmbCliente.SelectedValue.ToString());
                if (con.UpEventos(eve))
                {

                    lblAlerta.Text = "Sucesso ao cadastrar";
                    lblAlerta.Visible = true;
                    tAlerta.Enabled = true;
                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a atualização dos dados.");
                    msg.ShowDialog();
                }
            }
            dgvConsultaEven.DataSource = con.ShowEvento();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                msg.ShowDialog();

                if (msg.Resposta == true)
                {
                    if (con.DelEventos(idEvento))
                    {
                        lblAlerta.Text = "Sucesso ao Excluir Cliente";
                        lblAlerta.Visible = true;
                        tAlerta.Enabled = true;
                    }
                    else
                    {
                        Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.\nTente antes excluir os outros dados vinculados a \neste evento.");
                        msgn.ShowDialog();
                    }
                    dgvConsultaEven.DataSource = con.ShowEvento();
                    Limpar();
                }
            }
            else
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
        }

        private void dgvAdicionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdicionais.CurrentRow != null)
            {
                idAdicional = dgvAdicionais.CurrentRow.Cells[0].Value.ToString();
                btnAdicionais.Text = "Excluir";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionadoAdicional = true;
            }
        }

        private void btnProdFunf_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGerenciarEventos tela = new frmGerenciarEventos();
            tela.Show();
        }

        private void btnCadAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdicionais tela = new frmAdicionais();
            tela.Show();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProdutos tela = new frmProdutos();
            tela.Show();
        }

        private void tAlerta_Tick_1(object sender, EventArgs e)
        {
            if (tCont >= 2)
            {
                MoveAnimation mexer = new MoveAnimation();
                Point ponto = new Point(23, 611);
                tAlerta.Enabled = false;
                mexer.Start(mpAlerta, ponto, TransitionType.Linear, 15);
                tCont = 0;
            }
            else
            {
                tCont++;
            }
        }

        private void btnCadTipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTipos tela = new frmTipos();
            tela.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvConsultaEven.DataSource = con.PesquisaEvento(cmbTipoPesquisa.SelectedIndex, pesquisa);
        }

        private void mpAlerta_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}

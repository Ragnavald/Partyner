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
    public partial class frmConvidado : MetroForm
    {
        public frmConvidado()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        bool selecionado = false;
        int tCont = 0;
        Admin user = Usuario.UsuarioAtual[0];
        string idConvidado = null;

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idConvidado = null;
            txtNomeConv.Clear();
            cmbEvento.SelectedIndex = -1;
            selecionado = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    if (txtNomeConv.Text != "" && cmbEvento.SelectedIndex != -1)
                    {
                        string nome = txtNomeConv.Text;
                        string idEvento = cmbEvento.SelectedValue.ToString();
                        Convidado convidado = new Convidado(nome, idEvento);
                        if (con.CadConvidados(convidado))
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
                            msg.ShowDialog();
                        }
                    }
                    else
                    {
                        Mensagem msg = new Mensagem("", "OK", "Campos vazios", "Por favor, preencha todos os campos.");
                        msg.ShowDialog();
                    }
                }
                else
                {
                    Limpar();
                }
            }
            catch (Exception)
            {

                throw;
            }
            dgvConvidados.DataSource = con.ShowConvidados();
        }

        private void dgvConvidado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Text = "Cancelar";
            selecionado = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            idConvidado = dgvConvidados.CurrentRow.Cells[0].Value.ToString();
            txtNomeConv.Text = dgvConvidados.CurrentRow.Cells[1].Value.ToString();
            cmbEvento.SelectedValue = dgvConvidados.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmConvidado_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvConvidados.DataSource = con.ShowConvidados();
            dgvConvidados.Columns["id_evento"].Visible = false;
            cmbEvento.DataSource = con.ShowEvento();
            cmbEvento.DisplayMember = "descrição";
            cmbEvento.ValueMember = "id";
            cmbEvento.SelectedIndex = -1;

            for (int i = 0; i < dgvConvidados.Columns.Count; i++)
            {
                DataGridViewColumn tamanhoColuna = dgvConvidados.Columns[i];
                tamanhoColuna.Width = 200;
            }
        }

        private void frmConvidado_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeConv.Text;
                string idEvento = cmbEvento.SelectedValue.ToString();
                if (nome != "" || cmbEvento.SelectedIndex != -1)
                {
                    Convidado convidado = new Convidado(nome, idEvento, idConvidado);
                    if (con.UpConvidados(convidado))
                    {
                        lblAlerta.Text = "Sucesso ao Atualizar";
                        lblAlerta.Visible = true;
                        tAlerta.Enabled = true;
                        Limpar();
                    }
                    else
                    {
                        Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a atualização dos dados.");
                        msg.ShowDialog();
                    }
                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Campos vazios", "Por favor, preencha todos os campos.");
                    msg.ShowDialog();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
            Limpar();
            dgvConvidados.DataSource = con.ShowConvidados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                msg.ShowDialog();
                if (msg.Resposta)
                {
                    Convidado conv = new Convidado(idConvidado);
                    if (con.DelConvidados(conv))
                    {
                        lblAlerta.Text = "Sucesso ao Deletar";
                        lblAlerta.Visible = true;
                        tAlerta.Enabled = true;
                    }
                    else
                    {
                        Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.\nTente antes excluir os outros dados vinculados a este evento.");
                        msgn.ShowDialog();
                    }
                    dgvConvidados.DataSource = con.ShowConvidados();
                }
            }
            else
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
            Limpar();
        }

        private void dgvConvidados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConvidados.CurrentRow != null)
            {
                idConvidado = dgvConvidados.CurrentRow.Cells[0].Value.ToString();
                txtNomeConv.Text = dgvConvidados.CurrentRow.Cells["nome"].Value.ToString();
                cmbEvento.SelectedValue = dgvConvidados.CurrentRow.Cells["id_evento"].Value.ToString();

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvConvidados.DataSource = con.PesquisaConvidados(pesquisa);
        }
    }
}

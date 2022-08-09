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
    public partial class frmFuncionario : MetroForm
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idFuncionario;
        bool selecionado = false;
        int tCont = 0;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar()
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idFuncionario = null;
            txtNomeFunc.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            selecionado = false;
        }

        private bool IsRG(string rg) 
        {
            try
            {
                char[] charRG = rg.ToCharArray();
                if (charRG.Length == 9)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selecionado)
                {
                    string nome = txtNomeFunc.Text, CPF = txtCPF.Text, RG = txtRG.Text, endereco = txtEndereco.Text, telefone = txtTelefone.Text;
                    if (nome != "" && CPF != "" && RG != "" && endereco != "" && telefone != "")
                    {
                        long rg, cpf;
                            if (Int64.TryParse(txtCPF.Text, out cpf))
                            {
                                if (Int64.TryParse(txtRG.Text, out rg))
                                {
                                    if (IsRG(rg.ToString()))
                                    {
                                        Funcionario func = new Funcionario(nome, telefone, CPF, RG, endereco);

                                        if (con.CadFuncionario(func))
                                        {
                                            MoveAnimation mexer = new MoveAnimation();
                                            lblAlerta.Text = "Sucesso ao cadastrar";
                                            Point ponto = new Point(23, 433);
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
                                        Mensagem msg = new Mensagem("", "OK", "Falha!", "Rg Precisa de 9 caracteres");
                                        msg.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira apenas números em rg");
                                    msg.Show();
                                }
                            }
                            else
                            {
                                Mensagem msg = new Mensagem("", "OK", "Falha!", "Por favor insira apenas números em cpf");
                                msg.Show();
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
            catch (Exception error)
            {
                throw error;
            }
            dgvFuncionarios.DataSource = con.ShowFuncionario();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvFuncionarios.DataSource = con.ShowFuncionario();
            for (int i = 0; i < dgvFuncionarios.Columns.Count; i++)
            {
                DataGridViewColumn tamanhoColuna = dgvFuncionarios.Columns[i];
                tamanhoColuna.Width = 157;
            }
        }

        private void frmFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void tAlerta_Tick(object sender, EventArgs e)
        {
            if (tCont >= 2)
            {
                MoveAnimation mexer = new MoveAnimation();
                Point ponto = new Point(23, 409);
                tAlerta.Enabled = false;
                mexer.Start(mpAlerta, ponto, TransitionType.Linear, 15);
                tCont = 0;
            }
            else
            {
                tCont++;
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFuncionarios.CurrentRow != null)
            {

                idFuncionario = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
                txtNomeFunc.Text = dgvFuncionarios.CurrentRow.Cells["nome"].Value.ToString();
                txtCPF.Text = dgvFuncionarios.CurrentRow.Cells["cpf"].Value.ToString();
                txtRG.Text = dgvFuncionarios.CurrentRow.Cells["rg"].Value.ToString();
                txtTelefone.Text = dgvFuncionarios.CurrentRow.Cells["telefone"].Value.ToString();
                txtEndereco.Text = dgvFuncionarios.CurrentRow.Cells["endereco"].Value.ToString();

                btnCadastrar.Text = "Cancelar";
                btnCadastrar.UseCustomBackColor = true;
                btnCadastrar.BackColor = Color.FromArgb(255, 100, 100);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                selecionado = true;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFunc.Text, CPF = txtCPF.Text, RG = txtRG.Text, endereco = txtEndereco.Text, telefone = txtTelefone.Text;
            if (nome != "" || CPF != "" || RG == "" || endereco != "" || telefone != "")
            {
                Funcionario func = new Funcionario(nome, telefone, CPF, RG, endereco, idFuncionario);
                if (con.UpFuncionario(func))
                {
                    lblAlerta.Text = "Sucesso ao Atualizar";
                    lblAlerta.Visible = true;
                    tAlerta.Enabled = true;
                }
                else
                {
                    Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a edição dos dados.");
                    msg.ShowDialog();
                }
            }
            else
            {
                Mensagem msg = new Mensagem("", "OK", "Campos vazios", "Por favor, preencha todos os campos.");
                msg.ShowDialog();
            }
            Limpar();
            dgvFuncionarios.DataSource = con.ShowFuncionario();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user.IsAdmin)
            {
                Mensagem msg = new Mensagem("Sim", "Não", "Confirmar Exclusão", "Tem certeza que deseja excluir esse registro?");
                msg.ShowDialog();

                if (msg.Resposta)
                {
                    Funcionario func = new Funcionario(idFuncionario);
                    if (con.DelFuncionario(func))
                    {
                        lblAlerta.Text = "Sucesso ao Deletar";
                        lblAlerta.Visible = true;
                        tAlerta.Enabled = true;
                    }
                    else
                    {
                        Mensagem msgn = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a exclusão dos dados.\nVocê não pode excluir um funcionário que está \nvinculado à um evento.");
                        msgn.ShowDialog();
                    }
                    dgvFuncionarios.DataSource = con.ShowFuncionario();
                    Limpar();
                }
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvFuncionarios.DataSource = con.PesquisaFunc(pesquisa, cmbTipoPesquisa.SelectedIndex);
        }

        private void txtCPF_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string cpf;
                cpf = txtCPF.Text.ToString();
                ValidaCPF to = new ValidaCPF();

                if (!to.IsCpf(cpf))
                {
                    lblCPF.Text = "CPF inválido!";
                    lblCPF.Visible = true;
                }
                else
                {
                    txtCPF.BackColor = Color.Green;
                    lblCPF.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Animation;
using Classes;

namespace Forms
{
    public partial class frmCliente : MetroForm
    {

        public frmCliente()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();
        string idCliente;
        bool selecionado = false;
        int tCont = 0;
        string cpf;
        Admin user = Usuario.UsuarioAtual[0];

        private void Limpar() 
        {
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseCustomBackColor = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            idCliente = null;
            txtNomeCli.Clear();
            txtCPF.Clear();
            selecionado = false;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            dgvClientes.DataSource = con.ShowClientes();

            for (int i = 0; i < dgvClientes.Columns.Count; i++)
            {
                DataGridViewColumn tamanhoColuna = dgvClientes.Columns[i];
                tamanhoColuna.Width = 200;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                idCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNomeCli.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                txtCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();

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
                    string nome = txtNomeCli.Text;
                    long cpfVal;
                    if (Int64.TryParse(txtCPF.Text, out cpfVal))
                    {
                        char[] charCPF = cpfVal.ToString().ToCharArray();
                        if (nome == "" && charCPF.Length != 11)
                        {
                            Mensagem msg = new Mensagem("", "OK", "Campos vazios ou incorretos", "Por favor, preencha todos os campos ou corrija-os.");
                            msg.ShowDialog();
                        }
                        else
                        {
                            for (int i = 0; i < charCPF.Length; i++)
                            {
                                cpf += charCPF[i].ToString();
                            }
                            Cliente cli = new Cliente(nome, cpf);
                            cpf = "";
                            if (con.CadCliente(cli))
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
                    }
                    else 
                    {
                        Mensagem msg = new Mensagem("", "OK", "Campos vazios ou incorretos", "Apenas numeros no cpf, sem pontuação.");
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
            dgvClientes.DataSource = con.ShowClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCli.Text, cpf = txtCPF.Text;
            Cliente cli = new Cliente(nome, cpf,  idCliente);
            if (con.UpCliente(cli))
            {
                lblAlerta.Text = "Sucesso ao Editar cliente";
                lblAlerta.Visible = true;
                tAlerta.Enabled = true;
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Falha!", "Ocorreu um erro durante a atualização dos dados.");
                msg.ShowDialog();
            }
            dgvClientes.DataSource = con.ShowClientes();
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
                    Cliente cli = new Cliente(idCliente);
                    if (con.DelCliente(cli))
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
                    dgvClientes.DataSource = con.ShowClientes();
                    Limpar();
                }
            }
            else 
            {
                Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para excluir dados. Por\nfavor, peça a um administrador que exclua o \nregistro selecionado.");
                msg.ShowDialog();
            }
        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            dgvClientes.DataSource = con.pesquisaCliente(pesquisa, cmbTipoPesquisa.SelectedIndex);
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

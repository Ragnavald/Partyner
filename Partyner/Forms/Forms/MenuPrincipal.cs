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
    public partial class MenuPrincipal : MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        
        private void mtCLientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente tela = new frmCliente();
            tela.Show();
        }

        private void mtFuncionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFuncionario tela = new frmFuncionario();
            tela.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            if (Usuario.UsuarioAtual.Count != 0)
            {
                Admin user = Usuario.UsuarioAtual[0];
                if (user.IsAdmin)
                {
                    lblUser.Text = "Usuario: Administrador";
                }
                else
                {
                    lblUser.Text = "Usuario: Comum";
                }
            }
            else 
            {
                Application.Exit();
            }
        }

        private void mtEventos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void mtConvidados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConvidado tela = new frmConvidado();
            tela.Show();
        }

        private void mtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtTrocarConta_Click(object sender, EventArgs e)
        {
            Application.Restart();
            /*Usuario.UsuarioAtual.Remove(Admin.UsuarioAtual[0]);

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();*/
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mtChamada_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaConvidados tela = new frmListaConvidados();
            tela.Show();
        }

        private void mtContabilidade_Click(object sender, EventArgs e)
        {
            if (Usuario.UsuarioAtual.Count != 0)
            {
                Admin user = Usuario.UsuarioAtual[0];
                if (user.IsAdmin)
                {
                    this.Hide();
                    frmContabilidade tela = new frmContabilidade();
                    tela.Show();
                }
                else 
                {
                    Mensagem msg = new Mensagem("", "OK", "Acessibilidade negada", "Você não tem permissão para abrir Lucros.");
                    msg.ShowDialog();
                }
            }
        }

        private void Clientes_Enter(object sender, EventArgs e)
        {
            mtCLientes.Focus();
        }

        private void Func_Enter(object sender, EventArgs e)
        {
            mtFuncionarios.Focus();
        }

        private void Eventos_Enter(object sender, EventArgs e)
        {
            mtEventos.Focus();
        }

        private void Convidados_Enter(object sender, EventArgs e)
        {
            mtConvidados.Focus();
        }

        private void Chamada_Enter(object sender, EventArgs e)
        {
            mtChamada.Focus();
        }

        private void Lucro_Enter(object sender, EventArgs e)
        {
            mtContabilidade.Focus();
        }

        private void Foco(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void mtSobreNos_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.ShowDialog();
        }

        private void Trocar_Enter(object sender, EventArgs e)
        {
            mtTrocarConta.Focus();
        }

        private void Sair_Enter(object sender, EventArgs e)
        {
            mtSair.Focus();
        }
    }
}

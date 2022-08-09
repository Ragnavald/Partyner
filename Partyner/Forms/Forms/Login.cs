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
using MetroFramework;
using Classes;
using System.IO;

namespace Forms
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            string senha = txtSenha.Text, usuario = cmbUser.SelectedValue.ToString();
            if (con.FazerLogin(usuario, senha) > 0)
            {
                bool isAdmin = con.IsAdmin(usuario, senha);
                this.Hide();
                Admin user = new Admin();
                user.SetNivelUser(isAdmin);
                MenuPrincipal menu = new MenuPrincipal();
                menu.ShowDialog();
                menu.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Por favor, verifique sua senha e tente novamente.", "Senha incorreta!", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            cmbUser.DataSource = con.ShowUsuarios();
            cmbUser.DisplayMember = "login";
            cmbUser.ValueMember = "id_usuario";
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {   
                btnLogin.PerformClick();
            }
        }
    }
}

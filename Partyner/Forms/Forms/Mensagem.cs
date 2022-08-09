using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace Forms
{
    public partial class Mensagem : MetroForm
    {
        public Mensagem()
        {
            InitializeComponent();
        }

        public bool Resposta = false;
        public string botao1;
        public string botao2;
        public string titulo;
        public string texto;

        public Mensagem(string botao1, string botao2, string titulo, string texto)
        {
            InitializeComponent();

            this.botao1 = botao1;
            this.botao2 = botao2;
            this.titulo = titulo;
            this.texto = texto;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Resposta = true;
            this.Close();
        }

        private void txtNão_Click(object sender, EventArgs e)
        {
            Resposta = false;
            this.Close();
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {
            this.FocusMe();
            lblTitulo.Text = titulo;
            lblTexto.Text = texto;
            if (botao1 == "")
            {
                btn1.Hide();
            }
            else
            {
                btn1.Text = botao1;
            }
            if (botao2 == "")
            {
                btn2.Hide();
            }
            else
            {
                btn2.Text = botao2;
            }
        }
    }
}

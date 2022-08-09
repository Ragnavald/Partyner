using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Admin : Usuario
    {
        private string idUsuario;

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public void getIsAdmin() 
        {
            UsuarioAtual.Add(this);
        }

        public void SetNivelUser(bool admin) 
        {
            this.IsAdmin = admin;
            getIsAdmin();
        }

        public void Cadastrar(string usuario, bool isAdmin, string senha) 
        {
            this.Usuario = usuario;
            this.Senha = senha;
            this.IsAdmin = isAdmin;
        }
    }
}

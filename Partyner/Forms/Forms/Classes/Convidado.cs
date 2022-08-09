using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Convidado
    {
        private string idConvidado;

        public string IdConvidado
        {
            get { return idConvidado; }
            set { idConvidado = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private bool presenca;

        public bool Presenca
        {
            get { return presenca; }
            set { presenca = value; }
        }

        private string idEvento;

        public string IdEvento
        {
            get { return idEvento; }
            set { idEvento = value; }
        }

        public Convidado(string nome, string idEvento, string idConvidado)
        {
            this.nome = nome;
            this.presenca = false;
            this.idEvento = idEvento;
            this.idConvidado = idConvidado;
        }

        public Convidado(string nome, string idEvento) 
        {
            this.nome = nome;
            this.presenca = false;
            this.idEvento = idEvento;
        }

        public Convidado(string idConvidado) 
        {
            this.idConvidado = idConvidado;
        }
    }
}

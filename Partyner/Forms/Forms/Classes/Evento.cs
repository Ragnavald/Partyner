using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Evento
    {
        private string id_evento;

        public string Id_evento
        {
            get { return id_evento; }
            set { id_evento = value; }
        }

        private DateTime dataEvento;

        public DateTime DataEvento
        {
            get { return dataEvento; }
            set { dataEvento = value; }
        }

        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private double custos;

        public double Custos
        {
            get { return custos; }
            set { custos = value; }
        }

        private string idTipo;

        public string IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string idCliente;

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private int nmc;

        public int NMC
        {
            get { return nmc; }
            set { nmc = value; }
        }

        public Evento(string descricao, DateTime dataEvento, string idTipo, int nmc, string idCliente) 
        {
            this.descricao = descricao;
            this.dataEvento = dataEvento;
            this.idTipo = idTipo;
            this.idCliente = idCliente;
            this.nmc = nmc;
        }

        public Evento(string idEvento, string descricao, DateTime dataEvento, string idTipo, int nmc, string idCliente)
        {
            this.id_evento = idEvento;
            this.descricao = descricao;
            this.dataEvento = dataEvento;
            this.idTipo = idTipo;
            this.idCliente = idCliente;
            this.nmc = nmc;
        }
    }
}

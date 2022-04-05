using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lab_v1
{
    internal class Conta
    {
        private int ID { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Pais { get; set; }
        private string Password { get; set; }
        private string tipoUtilizador{ get; set; }

        public Conta()
        {
            this.ID = 0;
            this.Nome = string.Empty;
            this.Email = string.Empty;
            this.Pais = string.Empty;
            this.Password = string.Empty;
            this.tipoUtilizador = string.Empty;
        }
        public Conta(int _id, string _nome, string _email, string _pais, string _pass, string _tipoUtilizador)
        {
            this.ID = _id;
            this.Nome = _nome;
            this.Email = _email;
            this.Pais = _pais;
            this.Password = _pass;
            this.tipoUtilizador= _tipoUtilizador;   
        }
        public void EditarUtilizador(int _id, string _nome, string _email, string _pais, string _pass, string _tipoUtilizador)
        {
        }

        public void AddLista(int _id, string _nome, string _email, string _pais, string _pass, string _tipoUtilizador)
        {
        }
        public void EditarLista(int _id, string _nome, string _email, string _pais, string _pass, string _tipoUtilizador)
        {
        }
        public void EliminarLista(int _id, string _nome, string _email, string _pais, string _pass, string _tipoUtilizador)
        {
        }

    }
}

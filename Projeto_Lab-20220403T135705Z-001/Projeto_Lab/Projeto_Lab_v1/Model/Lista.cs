using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Lab_v1
{

    internal class Lista
    {
        private int ID { get; set; }
        private string Nome { get; set; }
        private Data.Data data { get; set; }
       
        LinkedList<Produto> lista ;
       
     


        public Lista()
        {
            this.ID = 0;
            this.Nome = String.Empty;
            this.lista = new LinkedList<Produto>();
            this.data = new Data.Data();
        }

        public Lista(int _id, string _nome, LinkedList<Produto> _lista, Data.Data _data)
        {
            ID = _id;
            Nome = _nome;
            lista = _lista;
            data = _data;
        }

        public void EditarLista(int _id, string _nome, LinkedList<Produto> _lista, Data.Data _data)
        {

        }

       public void CalculaPreco(int _id, string _nome, LinkedList<Produto> _lista, Data.Data _data)
       {

        }
        public void CalculaGasto(int _id, string _nome, LinkedList<Produto> _lista, Data.Data _data)
        {

        }

        public void ApagaItensComprados(int _id, string _nome, LinkedList<Produto> _lista, Data.Data _data)
        {

        }


    }
}

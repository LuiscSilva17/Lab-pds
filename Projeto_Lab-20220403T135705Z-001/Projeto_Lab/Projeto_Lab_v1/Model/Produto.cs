using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Lab_v1
{
    internal class Produto
    {
        private int ID { get; set; }
        private string Nome { get; set; }
        private float Preco { get; set; }
        private int Quantidade { get; set; }
        private string TipoUnidade { get; set; }
        LinkedList<Categoria> lista;

        public Produto()
        {
            this.ID = 0;
            this.Nome = string.Empty;
            this.Preco = 0;
            this.Quantidade = 0;
            this.TipoUnidade = string.Empty;
            lista = new LinkedList<Categoria>();
        }
        
        public Produto(int _id,string _nome,float _preco, int _quantidade,string _tipo, LinkedList<Categoria> _lista)
        {
            this.ID = _id;
            this.Nome = _nome;
            this.Preco = _preco;
            this.Quantidade = _quantidade;
            this.TipoUnidade = _tipo;
            this.lista = _lista;
        }



        public void AddProduto(int _id, string _nome, float _preco, int _quantidade, string _tipo, LinkedList<Categoria> _lista)
        {

        }
        void EditarProduto()
        {

        }

        void EliminarProduto()
        {

        }
        void MarcarComprado()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lab_v1
{
    public class Categoria
    { 
        private int ID { get; set; }
        private string Nome { get; set; }
        
        public Categoria ()
        {
            this.ID = 0 ;
            this.Nome = "Vazio";
        }

        public Categoria(int _id, string _nome)
        {
            this.ID = _id;
            this.Nome = _nome;
        }
        public void AddCategoria(int _id, string _nome)
        {

        }
        public void EditarCategoria(int _id, string _nome)
        {

        }

        public void EliminarCategoria(int _id, string _nome)
        {

        }

    }
}

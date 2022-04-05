using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lab_v1.Data
{
    internal class Data
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

        public Data()
        {
            this.Dia = 0;
            this.Mes = 0;
            this.Ano = 0;  
        }
        public Data(int _dia, int _mes, int _ano)
        {
            this.Dia = _dia;
            this.Mes = _mes;
            this.Ano = _mes;
        }

        public void AddData(int _dia, int _mes, int _ano)
        {

        }
        public void EditarData(int _dia, int _mes, int _ano)
        {

        }
        public void EliminarData(int _dia, int _mes, int _ano)
        {

        }
    }
}

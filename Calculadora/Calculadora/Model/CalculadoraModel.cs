using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Calculadora.Model
{
    public class CalculadoraModel
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int ID { get; set; }
        public int NumeroUm { get; set; }
        public int NumeroDois { get; set; }
        public string Operador { get; set; }
    }
}

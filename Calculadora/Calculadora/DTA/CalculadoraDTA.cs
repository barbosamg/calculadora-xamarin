using Calculadora.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.DTA
{
    public class CalculadoraDTA
    {
        public void Insert(CalculadoraModel objetoCalculadora)
        {
            SQLiteConnection conexao = Conexao.GetConexao();
            conexao.Insert(objetoCalculadora);
            conexao.Commit();
            conexao.Close();
        }
    }
}

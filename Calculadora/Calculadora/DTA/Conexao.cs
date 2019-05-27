using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Calculadora.Model;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Calculadora.DTA
{
    public class Conexao
    {
        //public static string path = @"D:\Users\mateus.barbosa\Documents\SENAC-UC1\banco_de_dados\aula_03\calc.db";
        public static string path = @"C:\temp\calculadora.db";
        public static SQLiteConnection GetConexao()
        {
            bool storeDateTimeAsTicks = false;
            SQLiteConnection conn = new SQLiteConnection(path, storeDateTimeAsTicks: storeDateTimeAsTicks);
            return conn;
        }

        public void CriarBanco(bool storeDateTimeAsTicks = false)
        {
            var db = Conexao.GetConexao();
            db.CreateTable<CalculadoraModel>();
            db.Commit();
            db.Close();
        }
    }
}

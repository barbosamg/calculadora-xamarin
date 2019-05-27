using Calculadora.DTA;
using Calculadora.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Business
{
    public class CalculadoraBusiness
    {
        public void InsereDados(int pNumeroUm, int pNumeroDois, string pOperador)
        {
            string operador = "";
            CalculadoraDTA calculadoraDTA = new CalculadoraDTA();
            CalculadoraModel calculadoraModel = new CalculadoraModel();

            switch (pOperador)
            {
                case "soma":
                    operador = "+";
                    break;
                case "subtracao":
                    operador = "-";
                    break;
                case "divisao":
                    operador = "/";
                    break;
                case "multiplicacao":
                    operador = "*";
                    break;
            }

            calculadoraModel.NumeroUm = pNumeroUm;
            calculadoraModel.NumeroDois = pNumeroDois;
            calculadoraModel.Operador = operador;

            calculadoraDTA.Insert(calculadoraModel);
        }
    }
}

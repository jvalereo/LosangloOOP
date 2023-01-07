using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace DiagonalOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, double
        //Jonas Valereo - Técnico em Informática 

        //declarando os attributos , campos e variaveis da classe dados
        //declarando tipo private, tipo double

        private double _diagonalmaior;
        private double _diagonalmenor;


        //declarando o construtor da classe dados
        public Dados(double diagonalmaior, double diagonalmenor)
        {
            _diagonalmaior = diagonalmaior;
            _diagonalmenor = diagonalmenor;
        }

        //declarando o metodo da classe dados
        public double Media()
        {
            return (_diagonalmaior + _diagonalmenor) / 2.0;
        }

        //declarando modificador da class dados, tipo string

        public override string ToString()
        {
            return "Media diagonal " + Media().ToString("F2", CultureInfo.InvariantCulture);
        }

        //fim da classe dados
    }
}

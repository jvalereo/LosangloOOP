using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiagonalOOP.Classe.Dados;

namespace DiagonalOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //Programa, Area da diagonal
            //Jonas Valereo - Técnico em Informática 

            //declarando chamando form2, fechando form1

            this.Visible = false;
            Form2 d = new Form2();
            d.ShowDialog();
            this.Visible = false;

            //fim do programa buttom acessear
        }

        //fim do programa
    }
}

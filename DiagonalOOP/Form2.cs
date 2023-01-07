using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DiagonalOOP.Classe.Dados;

namespace DiagonalOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //Programa, Area da diagonal
            //Jonas Valereo - Técnico em Informática 

            //declarando validação das textbox, if

            //declarando a validade da textboxdiagonalmaior
            if(textBoxDiagoMaior.Text == "")
            {
                MessageBox.Show("Digite diagonal maior!", "Messagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxDiagoMaior.BackColor = Color.Aqua;
                textBoxDiagoMaior.Focus();

                return;
            }

            //declarando a validade da textboxdiagonalmenor
            if(textBoxDiagoMenor.Text == "")
            {
                MessageBox.Show("Digite diagonal menor!", "Messagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxDiagoMenor.BackColor = Color.Aqua;
                textBoxDiagoMenor.Focus();

                return;
            }

            //fim da autenticação das textbox

            /*declarando o codigo entrada de dado na textBox,
            declarando variaveis auxiliares*/
            double diagonalmaior = double.Parse(textBoxDiagoMaior.Text,
                CultureInfo.InvariantCulture);
            double diagonalmenor = double.Parse(textBoxDiagoMenor.Text,
                CultureInfo.InvariantCulture);

            //declarando o objeto d da classe dados
            Dados d = new Dados(diagonalmaior, diagonalmenor);


            /*declarando, imprimir saida de dados messageBox, chamando o objeto m,
           chamando o método toString da classe dados*/

            MessageBox.Show(d.ToString(), "Messagem" , MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            //declarando limpando textbox, apos insedir dados
            textBoxDiagoMaior.Clear();
            textBoxDiagoMenor.Clear();
            textBoxDiagoMaior.Focus();
            textBoxDiagoMaior.BackColor = Color.White;
            textBoxDiagoMenor.BackColor = Color.White;

            //fim do programa button clique

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //declarando limpa textbox cancelar

            textBoxDiagoMaior.Clear();
            textBoxDiagoMenor.Clear();
            textBoxDiagoMaior.Focus();
            textBoxDiagoMaior.BackColor = Color.White;
            textBoxDiagoMenor.BackColor = Color.White;

           //fim do pograma button cancelar

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //declarando close, fechar programa

            Close();

            //fim do programa buttom fechar
        }

        //fim do programa
    }
}

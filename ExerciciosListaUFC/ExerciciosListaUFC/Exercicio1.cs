using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosListaUFC
{
    public partial class Exercicio1 : Form
    {
        
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double taxaDeIluminacaoPublica = 10;
            double pE, pN, r;
            pE = Double.Parse(pEconomico.Text);
            pN = Double.Parse(pNormal.Text);
            r = (pE * 0.10) + (pN * 0.13) + taxaDeIluminacaoPublica;
            string saida = "R$" + r ;
            resultado.Text = saida;
        }

        private void pEconomico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                return;
            else
            {
                e.Handled = true;
                MessageBox.Show("Somente números por favor!");
            }
        }

        private void pNormal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                return;
            else
            {
                e.Handled = true;
                MessageBox.Show("Somente números por favor!");
            }
        }
    }
}

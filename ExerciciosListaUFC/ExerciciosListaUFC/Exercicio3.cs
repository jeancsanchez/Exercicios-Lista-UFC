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
    public partial class Exercicio3 : Form
    {
        const double pi = 3.14;
        const double preco = 100;
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            double altura, raio, result;
            string output = "R$ ";
            raio = Convert.ToSingle(textBox1.Text);
            altura = Convert.ToSingle(textBox1.Text);
            result = ((Math.PI * Math.Pow(raio, 2) * 2*preco)  +  (2 * Math.PI * raio * altura *preco));
            output += Convert.ToSingle(result) +"\n";
            txtResultado.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Somente números por favor!");
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Somente números por favor!");
                e.Handled = true;
            }
        }
    }
}

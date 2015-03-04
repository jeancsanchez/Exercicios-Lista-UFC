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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Exercicio2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anos;
            double resultado;
            string outp = "";
            anos = Int32.Parse(textBox1.Text);
            resultado = (((60*60)*24)*365)*anos;
            outp += resultado + " Batidas de coração em " + anos + " anos.";
            label1.Text = outp;
            label1.ForeColor = Color.Red;
            pictureBox1.Visible = true;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

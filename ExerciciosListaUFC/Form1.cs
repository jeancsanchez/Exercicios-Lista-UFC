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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Exercicio1 f = new Exercicio1();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercicio2 x = new Exercicio2();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exercicio3 y = new Exercicio3();
            y.Show();
        }
    }
}

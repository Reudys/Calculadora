using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        //----------------------Botones-----------------------

        private void button1_Click(object sender, EventArgs e)
        {
            Sumar(txtNum1.Text, txtNum2.Text);
        }

        //---------------------Labels-------------------------

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //--------------------Metodos------------------------

        private void Sumar(String txtnum1, String txtnum2)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            int suma = num1 + num2;

            txtRespuesta.Text = suma.ToString();
        }

    }
}

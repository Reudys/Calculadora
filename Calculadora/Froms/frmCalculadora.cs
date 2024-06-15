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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //---------------Metodos--------------
        private string Sumar()
        {
            int num = int.Parse(txtNum1.Text);
            int mun = int.Parse(txtNum2.Text);

            int suma = num + mun;

            string txtSuma = suma.ToString();

            return txtSuma;
        }

        private string Restar()
        {
            int num = int.Parse(txtNum1.Text);
            int mun = int.Parse(txtNum2.Text);

            int resta = num - mun;

            string txtResta = resta.ToString();

            return txtResta;
        }

        private string Multiplicar()
        {
            int num = int.Parse(txtNum1.Text);
            int mun = int.Parse(txtNum2.Text);

            int multi = num * mun;

            string txtMulti = multi.ToString();

            return txtMulti;
        }

        private string Dividir()
        {
            int num = int.Parse(txtNum1.Text);
            int mun = int.Parse(txtNum2.Text);

            if (num != 0 && mun != 0) {
                int divi = num / mun;

                string txtDivi = divi.ToString();

                return txtDivi;
            }else
            {
                return "No se puede dividir entre 0";
            }
        }
        //---------------ImgBtn-------------------
        private void imgSuma_Click(object sender, EventArgs e)
        {
            Sumar();
            txtRespuesta.Text = Sumar();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Restar();
            txtRespuesta.Text = Restar();
        }

        private void imgMulti_Click(object sender, EventArgs e)
        {
            Multiplicar();
            txtRespuesta.Text = Multiplicar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dividir();
            txtRespuesta.Text = Dividir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }
    }   
}

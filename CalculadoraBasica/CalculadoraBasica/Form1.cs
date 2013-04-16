using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Sencilla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int n1, n2, resultado;
        public float f1, f2, fres;
        private void btSuma_Click(object sender, EventArgs e)
        {
            if (tbNumero1 != null && tbNumero2 != null)
            {
                n1 = int.Parse(tbNumero1.Text);
                n2 = int.Parse(tbNumero2.Text);
                resultado = n1 + n2;
                lbResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Ingresa al menos un numero en cada casilla", "ERROR");
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            if (tbNumero1 != null && tbNumero2 != null)
            {
                n1 = int.Parse(tbNumero1.Text);
                n2 = int.Parse(tbNumero2.Text);
                resultado = n1 - n2;
                lbResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Ingresa al menos un numero en cada casilla", "ERROR");
        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            if (tbNumero1 != null && tbNumero2 != null)
            {
                n1 = int.Parse(tbNumero1.Text);
                n2 = int.Parse(tbNumero2.Text);
                resultado = n1 * n2;
                lbResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Ingresa al menos un numero en cada casilla", "ERROR");
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (tbNumero1 != null && tbNumero2 != null)
            {
                f1 = int.Parse(tbNumero1.Text);
                f2 = int.Parse(tbNumero2.Text);
                fres = n1 / n2;
                lbResultado.Text =  fres.ToString();
            }
            else
                MessageBox.Show("Ingresa al menos un numero en cada casilla", "ERROR");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

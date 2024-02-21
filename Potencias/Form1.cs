using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese un número y una potencia.");
                return;
            }
            double numero, potencia;
            if (!double.TryParse(txtNumero.Text, out numero) || !double.TryParse(textBox2.Text, out potencia))
            {
                MessageBox.Show("Ingrese números válidos.");
                return;
            }

            double resultado = Math.Pow(numero, potencia);

            txtNumero.Text = resultado.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFimc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void imc()
        {
            double peso, altura, imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = peso / (altura * altura);

            MessageBox.Show("Seu IMC é: " + imc.ToString("F2"), "Resultado IMC", MessageBoxButtons.OK);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imc();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;
              txtPeso.Text = string.Empty;
            
        }
    }
}

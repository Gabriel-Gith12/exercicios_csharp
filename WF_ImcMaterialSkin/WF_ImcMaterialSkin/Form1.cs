using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ImcMaterialSkin
{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        private void imc()
        {
            double peso, altura, imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = peso / (altura * altura);

            MessageBox.Show("Seu IMC é: " + imc.ToString("F2"), "Resultado IMC", MessageBoxButtons.OK);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = string.Empty;
              txtPeso.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imc();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                btnTheme.Text = "DARK";
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }
            else
            {
                btnTheme.Text = "LIGHT";
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            }
        }
    }
}

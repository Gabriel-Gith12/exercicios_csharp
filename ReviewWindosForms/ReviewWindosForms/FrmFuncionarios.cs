using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewWindosForms
{
    public partial class FrmFuncionarios : Form
    {
        List<string> funcionarios = new List<string>();
        public FrmFuncionarios()
        {
            InitializeComponent();
        }
        private void LimparEFocar()
        {
            txtDescProduto.Text = String.Empty;
            txtDescProduto.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtDescProduto.Text == "")
            {
                MessageBox.Show("Digite um Funcionario");
                txtDescProduto.Focus();
            }
            else
            {
                funcionarios.Add(txtDescProduto.Text);
                lbfuncionarios.DataSource = null;
                lbfuncionarios.DataSource = funcionarios;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int index = lbfuncionarios.SelectedIndex;
            if (index < -1)
            {
                MessageBox.Show("Selecione o  veículos");
                return;
            }
            lbfuncionarios.Items.RemoveAt(index);
            lblMsg.Text = "Veículo removido com sucesso";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparEFocar();
        }
    }
    }
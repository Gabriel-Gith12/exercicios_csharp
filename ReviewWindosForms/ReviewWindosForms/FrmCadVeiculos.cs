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
    public partial class FrmCadVeiculos : Form
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        public FrmCadVeiculos()
        {
            InitializeComponent();
        }

        private void LimparEFocar()
        {
            txtNome.Text = String.Empty;
            txtNome.Focus();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                lstVeiculos.Items.Add(txtNome.Text);

                Veiculo veiculo = new Veiculo();
                veiculo.Nome = txtNome.Text;
                veiculo.IsAquec = chkBanco.Checked;
                veiculo.IsDual = chkDual.Checked;               
                veiculo.IsTetoSolar = chkTeto.Checked;
                veiculo.IsAutomatico = optSim.Checked;

                veiculos.Add(veiculo);

                ListViewItem listViewItem = new ListViewItem(txtNome.Text);
                int posicao = cbxMarca.SelectedIndex;
                string marca = cbxMarca.Items[posicao].ToString();

                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(null,marca));

                lvlVeiculos.Items.Add(listViewItem);

                string auto = veiculo.IsAutomatico ? "sim" : "não";

                if (veiculo.IsAutomatico)
                {
                    auto = "Sim";
                }
                else
                {
                    auto = "Não";
                }

                string equipamentos = veiculo.IsDual ? "Ar Dual, " : "";
                equipamentos += veiculo.IsAquec ? "Aquec Banco, " : "";
                equipamentos += veiculo.IsTetoSolar ? "Teto solar, " : "";
                equipamentos = equipamentos.Substring(0, equipamentos.Length - 2);

                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, auto));
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(null, equipamentos));

                LimparEFocar();
                lblMsg.Text = "Veículo cadastrado com sucesso";
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparEFocar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = lstVeiculos.SelectedIndex;
            if(index < -1)
            {
                MessageBox.Show("Selecione o  veículos");
                return;
            }
            lstVeiculos.Items.RemoveAt(index);
            lblMsg.Text = "Veículo removido com sucesso";
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text.Length < 2 && !String.IsNullOrEmpty(txtNome.Text)) 
            {
                MessageBox.Show("Tamanho mínino 2 caracteres");
                txtNome.Focus();
                txtNome.Text = String.Empty;
            }
        }

        private void frmCadVeiculos_Load(object sender, EventArgs e)
        {
            lblMsg.Text = String.Empty;
            LimparEFocar();
            chkDual.CheckState = CheckState.Unchecked;
            chkBanco.CheckState = CheckState.Unchecked;
            chkTeto.CheckState = CheckState.Unchecked;
            cbxMarca.Items.Add("Citroen");
        }

        private void chkDual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBanco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTeto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxMarca.SelectedIndex;
            Console.WriteLine("marca selecionada:" + cbxMarca.Items[index].ToString());
        }
    }
}

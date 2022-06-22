using Entidades.Produtos;
using Negocio.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Produtos
{
    public partial class FrmRotAdicionarPizza : Form
    {
        List<SaborPizza> saboresDisponiveis = new List<SaborPizza>();
        public List<SaborPizza> saboresSelecionados = new List<SaborPizza>();
        public int codigoTamanhoPizza = 0;
        public int codigoSaborBorda = 0;

        public FrmRotAdicionarPizza()
        {
            InitializeComponent();
        }

        private void FrmRotAdicionarPizza_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            saboresDisponiveis = new SaborPizzaNG().ListarSaboresPizza();

            if (saboresDisponiveis.Count <= 0)
            {
                MessageBox.Show("Sabores não Cadastrado", 
                    this.Text, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            PreencherListaSaboresDisponiveis(saboresDisponiveis);
        }
        private void PreencherListaSaboresDisponiveis(List<SaborPizza> saborPizzas)
        {
            lvlSabores.Clear();
            lvlSabores.View = View.Details;
            lvlSabores.GridLines = true;
            lvlSabores.CheckBoxes = true;

            lvlSabores.Columns.Add("Cód. Sabor", 70, HorizontalAlignment.Left);
            lvlSabores.Columns.Add("Descrição do Item", 170, HorizontalAlignment.Left);
            lvlSabores.Columns.Add("Valor (R$)", 70, HorizontalAlignment.Right);

            foreach (var item in saborPizzas)
            {
                // montando a linha do listView
                var linha = new string[5];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao;
                linha[2] = item.ValorAdicional.ToString();
                linha[3] = "";
                linha[4] = "";
                // monta o objeto ListViewItem
                var itemListView = new ListViewItem(linha);
                // adicionar o item nos Itens da ListView
                lvlSabores.Items.Add(itemListView);
            }
            //Funcoes.ListViewCor(lvlPizzas);
        }

        private void btnBscTamanhoPizza_Click(object sender, EventArgs e)
        {

        }

        private void btnBscSaborBorda_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoTamanhoPizza_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtCodigoSaborBorda_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnCancelarPizza_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarPizza_Click(object sender, EventArgs e)
        {

        }

        private void chkAddBorda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lvlSabores_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var lista = lvlSabores.CheckedItems;
            var ListaSelecionados = new List<string>();
            for(int i =0; i < lista.Count; i++)
            {
                var codSabor = lista[i].Text;
                ListaSelecionados.Add(codSabor);
            }
            saboresSelecionados = saboresDisponiveis.
                Where(w => ListaSelecionados.
                Contains(w.Codigo.ToString()))
                .ToList();

            lvlSaboresSelecionados.Clear();
            lvlSaboresSelecionados.View = View.Details;
            lvlSaboresSelecionados.GridLines = true;
            lvlSaboresSelecionados.Columns.Add("Descrição do Item", 170, HorizontalAlignment.Left);

            foreach(var item in saboresSelecionados)
            {
                var itemListView = new ListViewItem(item.Descricao);
                lvlSaboresSelecionados.Items.Add(itemListView);
            }
        }
    }
}

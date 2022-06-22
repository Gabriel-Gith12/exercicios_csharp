using Entidades.Enumeradores;
using Entidades.Sistema;
using Negocio.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Pesquisas
{
    public partial class FrmPesquisaGenericaCliente : Form
    {

        // variavel para armazenar o codigo do usuario selecionado
        public int codigoRetorno = 0;

        public FrmPesquisaGenericaCliente(string strTitulo, Status status)
        {
            InitializeComponent();
            // atribui o novo título para a tela
            this.Text = strTitulo;
            if (status == Status.Ativo)
            {
                optAtivos.Checked = true;
            }
            else if (status == Status.Inativo)
            {
                optInativos.Checked = true;
            }
            else
            {
                optTodos.Checked = true;
            }
        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            PrepararListView();
            BuscarClientes();

        }

        private void BuscarClientes()
        {
            Status status;
            if (optAtivos.Checked)
            {
                status = Status.Ativo;
            }
            else if (optInativos.Checked)
            {
                status = Status.Inativo;
            }
            else
            {
                status = Status.Todos;
            }

            PrepararListView();


            var lista = new ClienteNG().ListarPesquisaCliente(status, txtBusca.Text.Trim());

            if (lista.Count < 1)
                return;

            PreencherLista(lista);


        }

        private void PrepararListView()
        {
            lvlListagem.Clear();
            lvlListagem.View = View.Details;
            lvlListagem.Columns.Add("Código", 50, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Nome", 170, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Celular", 90, HorizontalAlignment.Left);
        }


        // Carrega a lista de usuario cadastrados
        private void PreencherLista(List<EntidadeViewPesquisaCliente> listaRetorno)
        {
            foreach (var item in listaRetorno)
            {

                // montando a linha do listView
                var linha = new string[4];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Nome;
                linha[2] = item.Telefone;
                linha[3] = item.Celular;

                // monta o objeto ListViewItem
                var itemListView = new ListViewItem(linha);
                // adicionar o item nos Itens da ListView
                lvlListagem.Items.Add(itemListView);
            }
        }

        public void LimparCampos()
        {
            txtBusca.Text = string.Empty;
            codigoRetorno = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // verifica se não existe um item na lista selecionado
            if (lvlListagem.SelectedIndices.Count <= 0)
            {
                return;
            }
            // pega o indice da linha selecionada ( -1 significa nenhum selecionado)
            var indiceItemSelecionado = Convert.ToInt32(lvlListagem.SelectedIndices[0]);
            if (indiceItemSelecionado >= 0)
            {
                // obtem o codigo da primeira coluna do listView
                codigoRetorno = Convert.ToInt32(lvlListagem.Items[indiceItemSelecionado].Text);
                // executa o evento do botão sair
                btnSair_Click(btnSair, new EventArgs());
            }
        }

        // fecha a tela
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvlListagem_DoubleClick(object sender, EventArgs e)
        {
            btnConfirmar_Click(btnConfirmar, new EventArgs());
        }

        private void optTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (optTodos.Checked)
            {
                BuscarClientes();
            }
        }

        private void optAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (optAtivos.Checked)
            {
                BuscarClientes();
            }
        }

        private void optInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (optInativos.Checked)
            {
                BuscarClientes();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // se o texto da busca está vazio
            if (txtBusca.Text.Trim().Length < 3)
            {
                // para o evento do textBox
                return;
            }

            BuscarClientes();

        }
    }
}

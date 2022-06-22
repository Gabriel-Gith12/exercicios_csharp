using Entidades.Enumeradores;
using Entidades.Sistema;
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
    public partial class FrmPesquisaGenerica : Form
    {
        // variavel para exibir a listagem de usuarios
        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        // variavel para armazenar o codigo do usuario selecionado
        public int codigoRetorno = 0;

        public FrmPesquisaGenerica(string strTitulo, Status status)
        {
            InitializeComponent();
            // atribui o novo título para a tela
            this.Text = strTitulo;
            if (status == Status.Ativo)
            {
                optAtivos.Checked = true;
            }
            else if(status == Status.Inativo)
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
            var form = new Form() { 
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };

            PreencherLista(lista);
        }
        // Carrega a lista de usuario cadastrados
        private void PreencherLista(List<EntidadeViewPesquisa> listaRetorno)
        {
            // limpa a listView
            lvlListagem.Clear();
            // define o tipo de listView(detalhado)
            lvlListagem.View = View.Details;
            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Descrição", 280, HorizontalAlignment.Left);
            foreach(var item in listaRetorno)
            {
                if (!optTodos.Checked)
                {
                    if(optAtivos.Checked && item.Status != Entidades.Enumeradores.Status.Ativo)
                    {
                        continue;
                    }
                    if(optInativos.Checked && item.Status != Entidades.Enumeradores.Status.Inativo)
                    {
                        continue;
                    }
                }
                // montando a linha do listView
                var linha = new string[2];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao;
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
            if(indiceItemSelecionado >= 0)
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
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (optAtivos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void optInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (optInativos.Checked)
            {
                LimparCampos();
                PreencherLista(lista);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // se o texto da busca está vazio
            if (txtBusca.Text.Trim().Equals(string.Empty))
            {
                // para o evento do textBox
                return;
            }

            // linq Query

            // monta uma lista e filtra pela descrição
            var list = new List<EntidadeViewPesquisa>
                (from usuario in lista
                 where 
                     usuario.Descricao.Trim().ToLower()
                     .Contains( txtBusca.Text.Trim().ToLower() )
                 select usuario
                );
            PreencherLista(list);
        }
    }
}

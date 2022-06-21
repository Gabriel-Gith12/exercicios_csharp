using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNomes.Text))
            {
                /// adicionar o texto digitado no textBox na caixa de listagem.
                listBoxNomes.Items.Add(textBoxNomes.Text);
                /// limpar o texto digitado.
                textBoxNomes.Text = string.Empty;
                /// manter o foco do teclado.
                textBoxNomes.Focus();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            /// obtem o item selecionado da lista.
            var item = listBoxNomes.SelectedIndex;

            if (item != -1)
            {
                /// remove o item da lista passando por parametro o indice  do item.
                listBoxNomes.Items.RemoveAt(item);
            }
            else
            {
                /// exibe uma caixa de mensagem com um botão OK e com um icone de erro.
                MessageBox.Show("Nome não selecionado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
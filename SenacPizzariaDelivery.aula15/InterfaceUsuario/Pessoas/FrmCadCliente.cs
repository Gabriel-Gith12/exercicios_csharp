using Entidades.Pessoas;
using Entidades.Sistema;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
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

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadCliente : Form
    {
        public bool EhNovo { get; private set; }
        public bool IsSucesso { get; private set; }
        public int iCodEdicao { get; private set; }


        public FrmCadCliente()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigo);
        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
            var frmPesquisaCliente = new FrmPesquisaGenericaCliente("Listagem de Clientes", Entidades.Enumeradores.Status.Todos);
            frmPesquisaCliente.gbSituacao.Enabled = true;
            frmPesquisaCliente.ShowDialog();
            var retorno = frmPesquisaCliente.codigoRetorno;
            if (retorno < 1)
                return;
            txtCodigo.Text = retorno.ToString();
            txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            btnBscCliente.Focus();
            EhNovo = false;
        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();

            oCliente.Nome = txtNome.Text.Trim();
            oCliente.Telefone = Funcoes.RemoverMascaraCampoNumerico(txtTelefone);
            oCliente.Celular = Funcoes.RemoverMascaraCampoNumerico(txtCelular);
            oCliente.CodigoUsrAlteracao = Sessao.Usuario.Codigo;
            oCliente.DtAlteracao = DateTime.Now;
            oCliente.situacao = ucSituacao1.status;

            ClienteNG clienteNG = new ClienteNG();

            if (EhNovo)
            {
                if (clienteNG.Inserir(oCliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    LimparCampos();
                }
            }
            else
            {
                oCliente.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                if (clienteNG.Atualizar(oCliente))
                {
                    MessageBox.Show("Cliente alterado com sucesso");
                    LimparCampos();
                    if (iCodEdicao > 0)
                    {
                        IsSucesso = true;
                        this.Close();
                    }
                }
            }
        }

                private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            //Preparação da Lista
            PrepararLista();

            // btnCancelar => LimparCampos
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void PrepararLista()
        {

        }

        public void LimparCampos()
        {           
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtRua.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            EhNovo = true;
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(string.Empty))
                return;
            // Buscar cliente no BD
            var cliente = new ClienteNG().Buscar(Convert.ToInt32(txtCodigo.Text.Trim()));

            // aula 13
            if (cliente == null)
            {
                btnExcluir.Enabled = false;
                return;
            }
            EhNovo = false;
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtCelular.Text = cliente.Celular.ToString();

            LimparCamposEndereco();

            foreach (var endereco in cliente.Enderecos)
            {
                PreecherListaEnderecos(endereco);
            }

            ucSituacao1.InicializarSituacao(cliente.situacao);
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            btnExcluir.Enabled = true;
        }

        private void PreecherListaEnderecos(Entidades.Pessoas.Endereco endereco)
        {
            var linha = new string[6];

            linha[0] = string.Empty;
            linha[1] = endereco.Rua;
            linha[2] = endereco.Numero.ToString();
            linha[3] = endereco.Complemento;
            linha[4] = endereco.Bairro;
            linha[5] = endereco.Cidade;

            var itmx = new ListViewItem(linha);

            if (endereco.EhEnderecoPadrao) itmx.Checked = true;

            listListagemEndereco.Items.Add(itmx);
        }

        private void LimparCamposEndereco()
        {
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            chkEnderecoPadrao.Checked = false;

        }

        internal void InicializarEdicao(int codEdit)
        {
            IsSucesso = false;
            iCodEdicao = codEdit;
        }
    }
}
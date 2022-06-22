using Entidades.Enumeradores;
using Entidades.Pessoas;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using InterfaceUsuario.Pessoas;
using Negocio.Pessoas;
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
    public partial class FrmRotPedidos : Form
    {
        public FrmRotPedidos()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigoCliente);
            MascaraDinheiro.AplicarEventos(txtValorTele);
        }


        private void mtxtContato_Validating(object sender, CancelEventArgs e)
        {
            // captura valor do campo do contato
            var valorCampo = Funcoes.RemoverMascaraCampoNumerico(mtxtContato);

            if (valorCampo == null)
                return;
            // converter o valor para um numero

            // chamada clienteNG->clienteBD
            var ocliente = new ClienteNG().BuscarPorContato(Convert.ToInt64(valorCampo));
            // se cliente nao encontrado
            if (ocliente == null)
            {
                if (MessageBox.Show("Cliente não encontrado. Deseja realizar cadastro?",
                    "Cliente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var frmcad = new FrmCadCliente();
                    frmcad.WindowState = FormWindowState.Normal;
                    frmcad.StartPosition = FormStartPosition.CenterScreen;
                    frmcad.ShowDialog();
                }
                else
                {
                    mtxtContato.Focus();
                    mtxtContato.Select();
                }
            }
            else
            {
                txtCodigoCliente.Text = ocliente.Codigo.ToString();
                txtCodigoCliente_Validated(txtCodigoCliente, new CancelEventArgs());
                MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());
                btnBscCliente.Focus();

                lblMstNomeCliente.Text = ocliente.Nome;

                Endereco oEndereco = (from end in ocliente.Enderecos
                                      where end.EhEnderecoPadrao
                                      select end).FirstOrDefault();
                if (oEndereco == null)
                    return;
                txtMstRua.Text = oEndereco.Rua;
                txtMstNumero.Text = oEndereco.Numero.ToString();
                txtMstComplemento.Text = oEndereco.Complemento;
                txtMstBairro.Text = oEndereco.Bairro;
                txtMstCidade.Text = oEndereco.Cidade;
                lblCodEnderecoCliente.Text = oEndereco.Codigo.ToString();
                btnEditCliente.Enabled = true;
                btnEditEndereco.Enabled = true;


            }
        }

        private void chkTele_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTele.Checked)
            {
                txtValorTele.Enabled = true;
                txtValorTele.Focus();
            }
            else
            {
                txtValorTele.Enabled = false;
                txtValorTele.Text = string.Empty;
            }
        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
            var oFrm = new FrmPesquisaGenericaCliente("Clientes",
                Entidades.Enumeradores.Status.Ativo);
            oFrm.gbSituacao.Enabled = false;
            oFrm.ShowDialog();

            var codClienteRetorno = oFrm.codigoRetorno;

            if (codClienteRetorno < 1)
            {
                return;
            }
            txtCodigoCliente.Text = codClienteRetorno.ToString();
            txtCodigoCliente_Validated(txtCodigoCliente, new CancelEventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());
            btnBscCliente.Focus();
            
        }

        private void txtCodigoCliente_Validated(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Trim().Equals(string.Empty))
                return;
            var oCliente = new ClienteNG().Buscar
                (Convert.ToInt32(txtCodigoCliente.Text.Trim()));
            if (oCliente == null)
            {
                return;
            }
            lblMstNomeCliente.Text = oCliente.Nome;
            if (!oCliente.Telefone.Equals(string.Empty))
            {
                mtxtContato.Text = oCliente.Telefone.ToString();
            }
            else
            {
                mtxtContato.Text = oCliente.Celular.ToString();

                Endereco oEndereco = (from end in oCliente.Enderecos
                                      where end.EhEnderecoPadrao
                                      select end).FirstOrDefault();

                if (oEndereco == null)
                    return;

                txtMstRua.Text = oEndereco.Rua;
                txtMstNumero.Text = oEndereco.Numero.ToString();
                txtMstComplemento.Text = oEndereco.Complemento;
                txtMstBairro.Text = oEndereco.Bairro;
                txtMstCidade.Text = oEndereco.Cidade;
                lblCodEnderecoCliente.Text = oEndereco.Codigo.ToString();
                btnEditCliente.Enabled = true;
                btnEditEndereco.Enabled = true;
                btnEditCliente.Enabled = true;
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            mtxtContato.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;
            lblCodEnderecoCliente.Text = string.Empty;
            txtMstRua.Text = string.Empty;
            txtMstNumero.Text = string.Empty;
            txtMstComplemento.Text = string.Empty;
            txtMstBairro.Text = string.Empty;
            txtMstCidade.Text = string.Empty;
            btnEditEndereco.Enabled = true;
            btnEditCliente.Enabled = true;

            lvlAdicionais.Items.Clear();
            lvlPizzas.Items.Clear();
            lblTotalPedido.Text = "R$ 0,00";
            txtValorTele.Text = "R$ 0,00";
            chkTele.Checked = false;

            mtxtContato.Focus();
            mtxtContato.Select();
            MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValorTele, new EventArgs());         
            chkTele_CheckedChanged(chkTele, new EventArgs());
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Trim().Equals(string.Empty))
                return;

            FrmCadCliente frm = new FrmCadCliente();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.InicializarEdicao(Convert.ToInt32(txtCodigoCliente.Text.Trim()));
            frm.ShowDialog();

            if (frm.IsSucesso)
            {
                txtCodigoCliente_Validated(txtCodigoCliente, new CancelEventArgs());
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadCliente();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void PrepararListas()
        {
            //lblPizzas
            lvlPizzas.Clear();
            lvlPizzas.View = View.Details;
            lvlPizzas.Columns.Add("Cód. Tamanho", 0, HorizontalAlignment.Left);
            lvlPizzas.Columns.Add("Cód. Sabor", 0, HorizontalAlignment.Left);
            lvlPizzas.Columns.Add("Cód. Borda", 0, HorizontalAlignment.Left);
            lvlPizzas.Columns.Add("Descrição do Item", 800, HorizontalAlignment.Left);
            lvlPizzas.Columns.Add("Valor (R$)", 70, HorizontalAlignment.Right);

            //lvlAdicionais
            lvlAdicionais.Clear();
            lvlAdicionais.View = View.Details;
            lvlAdicionais.Columns.Add("Cód. Adicional", 0, HorizontalAlignment.Left);
            lvlAdicionais.Columns.Add("Descrição do Item", 800, HorizontalAlignment.Left);
            lvlAdicionais.Columns.Add("Valor (R$)", 70, HorizontalAlignment.Right);
        }

        private void FrmRotPedidos_Load(object sender, EventArgs e)
        {
            PrepararListas();
            btnCancelarPedido_Click(btnCancelarPedido, new EventArgs());
        }

        private void btnRemoveAdicional_Click(object sender, EventArgs e)
        {
            if (lvlAdicionais.SelectedIndices.Count < 1)
                return;

            int idIndice = lvlAdicionais.SelectedIndices[0];

            if (idIndice >= 0)
                lvlAdicionais.Items.RemoveAt(idIndice);
        }

        private void btnRemovePizza_Click(object sender, EventArgs e)
        {
            if (lvlPizzas.SelectedIndices.Count < 1)
                return;

                int idIndice = lvlPizzas.SelectedIndices[0];

                if (idIndice >= 0)
                    lvlPizzas.Items.RemoveAt(idIndice);
        }

        private void btnAddAdicional_Click(object sender, EventArgs e)
        {
            var adicionalNG = new AdicionalNG();
            // busca no banco de dados todos os adicinais ativos
            var adicionais = adicionalNG.ListarEntidadesViewPesquisa(Status.Ativo);
            if (adicionais.Count < 1)
            {
                MessageBox.Show("Nenhum adicional encontrado", this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var frmPesquisa = new FrmPesquisaGenerica("Lista de Adicionais", 
                Status.Ativo);

            frmPesquisa.gbSituacao.Enabled = false;
            frmPesquisa.lista = adicionais;
            frmPesquisa.ShowDialog();

            var codigoRetorno = frmPesquisa.codigoRetorno;
            if (codigoRetorno < 1)
                return;

            PreencherListaAdicionais(codigoRetorno);
            btnAddAdicional.Focus();
        }
        private void PreencherListaAdicionais(int codigo)
        {
            var adicionalNG = new AdicionalNG();
            // busca um ojeto adicional clompleto
            var adicional = adicionalNG.Buscar(codigo);
            // verifica se o ofjeto foi entrado
            if (adicional == null)
            {
                MessageBox.Show("Nenhum adicional encontrado!", 
                    this.Text,  
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            var linha = new string[3];
            linha[0] = adicional.Codigo.ToString();
            linha[1] = adicional.Descricao;
            linha[2] = adicional.Valor.ToString("C2");

            var itemAdicional = new ListViewItem(linha);
            lvlAdicionais.Items.Add(itemAdicional);

            Funcoes.ListViewCor(lvlAdicionais);
            AtualizarValorTotalPedido();
        }

        private void AtualizarValorTotalPedido()
        {
            decimal ValorTotal = 0;
            foreach (ListViewItem item in lvlAdicionais.Items)
                ValorTotal += Convert.ToDecimal(item.SubItems[2].Text.Replace("R$", "").Trim());
            foreach (ListViewItem item in lvlPizzas.Items)
                ValorTotal += Convert.ToDecimal(item.SubItems[4].Text.Replace("R$", "").Trim());

            if (chkTele.Checked)
            {
                MascaraDinheiro.TirarMascara(txtValorTele, new EventArgs());
                ValorTotal += Convert.ToDecimal(txtValorTele.Text.Trim());
                MascaraDinheiro.RetornarMascara(txtValorTele, new EventArgs());
            }
            lblTotalPedido.Text = ValorTotal.ToString("C2");
        }

        private void txtCodigoCliente_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtValorTele_Validating(object sender, CancelEventArgs e)
        {
            if (!chkTele.Checked)
                return;

            MascaraDinheiro.TirarMascara(txtValorTele, new EventArgs());
            var dValorTele = Convert.ToDecimal(txtValorTele.Text.Trim());
            MascaraDinheiro.RetornarMascara(txtValorTele, new EventArgs());

            if (dValorTele < 0)
            {
                MessageBox.Show("O valor da tele entrega não pode ser negativo.", 
                    this.Text, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            AtualizarValorTotalPedido();
        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            var frm = new FrmRotAdicionarPizza();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}

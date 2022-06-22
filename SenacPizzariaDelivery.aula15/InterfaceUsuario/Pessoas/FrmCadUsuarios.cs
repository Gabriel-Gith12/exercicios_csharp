using Entidades.Enumeradores;
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
    public partial class FrmCadUsuarios : Form
    {
        private bool ehNovo;
        public FrmCadUsuarios()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigoUsuario);
            MascaraCampoCodigo.AplicarEventos(txtCodigoTipoUsuario);
        }

        private void btnBscUsuario_Click(object sender, EventArgs e)
        {
            // chamada do UsuarioNG > UsuarioBD
            var listaUsuarios = new UsuarioNG()
                .ListarEntidadesViewPesquisa(Entidades.Enumeradores.Status.Todos);
            
            // se nao encontrar nenhum registro
            if(listaUsuarios.Count < 1)
            {
                MessageBox.Show(
                    "Sem dados para exibir.", 
                    "Alerta", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            // cria a tela de pesquisa
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de usuários", Status.Todos);
            // carrega a lista de usuarios cadastrados
            frmPesquisa.lista = listaUsuarios;
            // exibe a tela de pesquisa
            frmPesquisa.ShowDialog();

            if(frmPesquisa.codigoRetorno > 0)
            {
                txtCodigoUsuario.Text = frmPesquisa.codigoRetorno.ToString();

                txtCodigoUsuario_Validating(txtCodigoUsuario, new CancelEventArgs());
                btnBscUsuario.Focus();
            }
                


        }

        private void txtCodigoUsuario_Validating(object sender, CancelEventArgs e)
        {
            // verifica se o campo do codigo está vazio
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;
            // busca o usuario do banco (Negocio, BD)
            var codigo = Convert.ToInt32(txtCodigoUsuario.Text.Trim());

            var usuario = new UsuarioNG().Buscar(codigo);

            if (usuario == null)
                return;
            // habilita botao excluir
            btnExcluir.Enabled = true;
            // popula os campos da tela
            txtNomeUsuario.Text = usuario.Nome;
            txtLoginUsuario.Text = usuario.Login;
            txtSenhaUsuario.Text = usuario.Senha;

            // popula o codigo do tipo do usuario 
            txtCodigoTipoUsuario.Text = usuario.TipoUsuario.Codigo.ToString();
            // executa o evento validating do tipo do usuario
            // para popular a descricao do tipo
            txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new CancelEventArgs());

            // setar o valor do ativo ou inativo
            ucSituacao1.InicializarSituacao(usuario.Status);

            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());
        }

        public void LimparCampos()
        {
            // limpas os campos texto
            txtCodigoUsuario.Text = new UsuarioNG().BuscarProximoCodigo().ToString();
            txtNomeUsuario.Text = string.Empty;
            txtLoginUsuario.Text = string.Empty;
            txtSenhaUsuario.Text = string.Empty;
            txtCodigoTipoUsuario.Text = string.Empty;
            lblMstTipoUsuario.Text = string.Empty;
            // desabilita o botao excluir
            btnExcluir.Enabled = false;
            // seta o valor ativo 
            ucSituacao1.InicializarSituacao(Status.Ativo);
            // formata a mascara do campo codigo
            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());
            // definir o foco do teclado no campo do nome do usuario
            txtNomeUsuario.Focus();
            txtNomeUsuario.Select();
            ehNovo = true;
        }

        private void txtCodigoTipoUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoTipoUsuario.Text.Trim().Equals(string.Empty))
                return;
            // pega o codigo digitado dentro do txtCodigoTipoUsuario
            var codigo = Convert.ToInt32(txtCodigoTipoUsuario.Text.Trim());
            // busca o tipo do usuario
            var tipoUsuario = new TipoUsuarioNG().Buscar(codigo);

            if (tipoUsuario == null)
            {
                MessageBox.Show("Tipo de usuário não cadastrado.");
                txtCodigoTipoUsuario.Focus();
                return;
            }
            else
            {
                // carrega a descricao do tipo do usuario
                lblMstTipoUsuario.Text = tipoUsuario.Descricao;
            }
            btnBscTipoUsuario.Focus();
        }

        private bool ValidarCampos()
        {
            if (txtNomeUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Nome deve ser informado.",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (txtLoginUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Login deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSenhaUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Senha deve ser informada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCodigoTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Tipo de usuário deve ser informado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // validar o preenchimento dos campos

            if (!ValidarCampos())
                return;

            var usuario = new Usuario();

            usuario.Nome = txtNomeUsuario.Text;
            usuario.Login = txtLoginUsuario.Text;
            usuario.Senha = txtSenhaUsuario.Text;
            usuario.TipoUsuario = new TipoUsuario() { Codigo = Convert.ToInt16(txtCodigoTipoUsuario.Text) };
            usuario.Status = ucSituacao1.status;
            usuario.CodigoUsrAlteracao = Sessao.Usuario.Codigo;

            if(ehNovo == true)
            {
                // inserir
                bool inseriu = new UsuarioNG().Inserir(usuario);

                if (inseriu)
                {
                    MessageBox.Show("Registro cadastrado com sucesso.",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // atualizar
                bool atualizou = new UsuarioNG().Atualizar(usuario);

                if (atualizou)
                {
                    MessageBox.Show("Registro atualizado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnBscTipoUsuario_Click(object sender, EventArgs e)
        {
            // chamada do TipoUsuarioNG > TipoUsuarioBD
            var listaTiposUsuarios = new TipoUsuarioNG()
                .ListarEntidadesViewPesquisa(Entidades.Enumeradores.Status.Todos);

            // se nao encontrar nenhum registro
            if (listaTiposUsuarios.Count < 1)
            {
                MessageBox.Show(
                    "Sem dados para exibir.",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            // cria a tela de pesquisa
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de tipos de  usuários", Status.Todos);
            // carrega a lista de tipos de usuarios cadastrados
            frmPesquisa.lista = listaTiposUsuarios;
            // exibe a tela de pesquisa
            frmPesquisa.ShowDialog();

            if (frmPesquisa.codigoRetorno > 0)
            {
                txtCodigoTipoUsuario.Text = frmPesquisa.codigoRetorno.ToString();

                txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new CancelEventArgs());
                
                MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());

                btnBscTipoUsuario.Focus();
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComSelect
{
    public class UsuarioBD
    {
        public void Consultar(int idDoUsuario)
        {
            using (var conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                /// Tentar
                try
                {
                    /// Abrir a conexão com o banco de Dados.
                    conexao.Open();
                    MessageBox.Show("Conectou no banco de dados locadora.", "SUCESSO");
                    /// Cria um comando MySql.
                    MySqlCommand command = new MySqlCommand();
                    /// Conecta o comando a conexão do banco de Dodos.
                    command = conexao.CreateCommand();
                    /// Cria o SELECT de consulta na tabela do Usuario.
                    command.CommandText = "SELECT id,nome FROM usuario WHERE id = @id";
                    command.Parameters.AddWithValue("id", idDoUsuario);
                    /// Cria um Leitor.
                    MySqlDataReader reader = command.ExecuteReader();
                    /// Enquanto o reader possui Registro
                    while (reader.Read())
                    {
                        /// Verifica se a coluna nome possui Valor
                        if (reader["nome"] != null)
                        {
                            MessageBox.Show("Usuario: id= " + reader["id"].ToString() + " - nome=" + reader["nome"].ToString());
                        }
                    }
                    /// Se nao der Certo
                }
                catch (MySqlException erro)
                {
                    /// Dar uma mensagem para o Usuário
                    MessageBox.Show("Erro na conexao:" + erro.Message, "ALERTA");
                }
                /// Por Fim
                finally
                {
                    /// Fechar a Conexão
                    conexao.Close();
                }
            }
        }

        public void Inserir(String nomeDoUsuario)
        {
            using (var conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                try
                {
                    if (string.IsNullOrEmpty(nomeDoUsuario))
                    {
                        MessageBox.Show("Informe o nome do Usuário");
                        /// textBoxInserir.Select();
                        return;
                    }
                    /// Abre a conexão com o banco de Dados(LOCADORA)
                    conexao.Open();
                    /// Criar um comando MySql
                    MySqlCommand comando = conexao.CreateCommand();
                    /// Inserir registro na tabela usuario
                    comando.CommandText = "INSERT INTO usuario (nome) values(@nomeUsuario);";
                    /// Adiciona parametro ao comando SQL substituindo @nomeUsuaio pelo texto do campo textBoxInserir
                    comando.Parameters.AddWithValue("nomeUsuario", nomeDoUsuario);
                    var retorno = comando.ExecuteNonQuery();

                    if (retorno < 1)
                    {
                        MessageBox.Show("ERRO AO INSERIR");
                    }
                    else
                    {
                        MessageBox.Show("Usuário cadastrado com Sucesso!");
                        /// Limpa a caixa de Texto.
                        ///  textBoxInserir.Text = string.Empty;
                        /// Coloca o foco na caixa de Texto
                        /// textBoxInserir.Select();
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("OPS: " + erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public void Alterar(string idDoUsuario, String nomeDoUsuario)
        {
            using (var conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                if (string.IsNullOrEmpty(idDoUsuario))
                {
                    MessageBox.Show("Id não Informado");
                    return;
                }
                if (string.IsNullOrEmpty(nomeDoUsuario))
                {
                    MessageBox.Show("Nome não Informado");
                    return;
                }
                try
                {
                    conexao.Open();
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "UPDATE usuario set nome = @nomeUsuario WHERE id = @id;";
                    comando.Parameters.AddWithValue("nomeUsuario", nomeDoUsuario);
                    comando.Parameters.AddWithValue("id", idDoUsuario);
                    var retorno = comando.ExecuteNonQuery();
                    if (retorno < 1)
                    {
                        MessageBox.Show("ERRO AO ATUALIZAR");
                    }
                    else
                    {
                        MessageBox.Show("Usuário alterado com Sucesso!");
                        /// textBoxId.Text = string.Empty;
                        /// textBoxNome.Text = String.Empty;
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("OPS: " + erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        public void Excluir(int idDoUsuario)
        {
            using (var conexao = ConexaoBD.GetInstancia().GetConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = conexao.CreateCommand();
                    comando.CommandText = "DELETE FROM usuario WHERE id = @id";
                    comando.Parameters.AddWithValue("id",(idDoUsuario));
                    int retorno = comando.ExecuteNonQuery();
                    if (retorno < 1)
                    {
                        MessageBox.Show("ERRO AO EXCLUIR O USUÁRIO");
                    }
                    else
                    {
                        MessageBox.Show("Usuário excluido com Sucesso!");
                        /// textBoxId.Text = string.Empty;
                        /// textBoxNome.Text = String.Empty;
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("OPS: " + erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
            }
    }
}
using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDeDados.Pessoas
{
    public class UsuarioBD
    {
        // método lista recebe por parametro a situacao do usuario(ativo, inativo, todos)
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();

            using( MySqlConnection conexao = 
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    // consulta SQL
                    string query = @"SELECT codigo, nome AS descricao, situacao 
                                            FROM usuario ";
                    // se status que eu quero pesquisar for diferente de todos
                    if(status != Status.Todos)
                    {
                        // adiciono a clausula WHERE
                        query += " WHERE situacao = @situacao";
                        comando.Parameters.AddWithValue("situacao", (int)status);
                    }

                    
                    comando.CommandText = query;
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();

                        // ler propriedades do data reader
                        // atribui valor ao codigo do usuario
                        // converte para inteiro
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["descricao"].ToString();
                        oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        listaEntidades.Add(oEntidade);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally {
                    conexao.Close();
                }
                
            }

            return listaEntidades;
        }

        public List<Usuario> ListarUsuarios()
        {
            var listaUsuario = new List<Usuario>();

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuario " +
                                          "WHERE situacao = 1; ";
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();

                        // ler propriedades do data reader
                        // atribui valor ao codigo do usuario
                        // converte para inteiro
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        listaUsuario.Add(oUsuario);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }

            }

            return listaUsuario;
        }

        public Usuario Buscar(int codigo)
        {
            var usuario = new Usuario();

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = " SELECT * FROM usuario " +
                                          " WHERE codigo = @codigo ";
                    comando.Parameters.AddWithValue("codigo", (int)codigo);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        usuario.Nome = reader["nome"].ToString();
                        usuario.Login = reader["login"].ToString();
                        usuario.Senha = reader["senha"].ToString();
                        usuario.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        usuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        usuario.Status = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        usuario.TipoUsuario = new TipoUsuario() { Codigo = Convert.ToInt16(reader["codigo_tipo_usuario"].ToString() )};
                    }
                }
                catch (MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }

            }

            return usuario;
        }

    }
}

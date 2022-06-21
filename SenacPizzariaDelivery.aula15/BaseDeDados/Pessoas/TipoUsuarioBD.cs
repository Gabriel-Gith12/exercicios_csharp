using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDeDados.Pessoas
{
    public class TipoUsuarioBD
    {
        // método lista recebe por parametro a situacao do usuario(ativo, inativo, todos)
        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    // consulta SQL
                    string query = @"SELECT codigo, descricao, '1' AS situacao 
                                            FROM tipo_usuario ";
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
                finally
                {
                    conexao.Close();
                }

            }

            return listaEntidades;
        }

        public TipoUsuario BuscarTipoUsuarioDoUsuario(int codigoUsuario)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    // abre a conexao
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    // cria o comando
                    comando = conexao.CreateCommand();
                    // define o sql do select, codigo, descricao do tipo de usuario
                    comando.CommandText = @"SELECT U.codigo_tipo_usuario as CodigoTipoUsuario, 
                                                   TU.Descricao          as DescricaoTipoUsuario 
                                            FROM 
                                                   usuario U
                                            INNER JOIN 
                                                   tipo_usuario TU ON U.codigo_tipo_usuario = TU.codigo
                                            WHERE U.codigo = @codigoUsuario
                                            ";
                    // adiciona o parametro na consulta
                    comando.Parameters.AddWithValue("codigoUsuario", codigoUsuario);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["CodigoTipoUsuario"].ToString());
                        tipoUsuario.Descricao = reader["DescricaoTipoUsuario"].ToString();
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

            return tipoUsuario;
        }

        public TipoUsuario Buscar(int codigo)
        {
            TipoUsuario tipoUsuario = new TipoUsuario();

            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    // abre a conexao
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    // cria o comando
                    comando = conexao.CreateCommand();
                    // define o sql do select, codigo, descricao do tipo de usuario
                    comando.CommandText = @"SELECT codigo, 
                                                   descricao
                                            FROM 
                                                   tipo_usuario 
                                            WHERE codigo = @codigo
                                            ";
                    // adiciona o parametro na consulta
                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        tipoUsuario.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        tipoUsuario.Descricao = reader["descricao"].ToString();
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

            return tipoUsuario;
        }
    }
}

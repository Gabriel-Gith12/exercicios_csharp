

using Entidades.Enumeradores;
using Entidades.Pessoas;
using Entidades.Sistema;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BaseDeDados.Pessoas
{
    public class ClienteBD
    {
        // busca clientes por status e nome
        public List<EntidadeViewPesquisaCliente> ListarPesquisaCliente(Status status, string nome)
        {
            var listaEntidades = new List<EntidadeViewPesquisaCliente>();

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
                    string query = @"SELECT codigo, nome , telefone, celular 
                                            FROM cliente ";

                    // se status que eu quero pesquisar for diferente de todos
                    if (status != Status.Todos)
                        query += " WHERE situacao = @situacao";


                    // se nome foi informado
                    if (!nome.Equals(string.Empty))
                    {
                        if (status == Status.Todos)
                            query += " WHERE ";
                        else
                            query += " AND ";

                        var termos = nome.Split(' '); // Raf[0] Suarez[1]
                        foreach (var termo in termos)
                        {
                            query += "nome LIKE '%" + termo + "%' AND";
                        }

                        query = query.Substring(0, query.Length - 3);
                    }

                    comando.CommandText = query;

                    if (status != Status.Todos)
                        comando.Parameters.AddWithValue("situacao", (int)status);

                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisaCliente();

                        // ler propriedades do data reader
                        // atribui valor ao codigo do usuario
                        // converte para inteiro
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Nome = reader["nome"].ToString();


                        if (reader["telefone"] != null)
                            oEntidade.Telefone = Convert.ToInt64(reader["telefone"]).ToString("(##) ####-####");
                        if (reader["celular"] != null)
                            oEntidade.Celular = Convert.ToInt64(reader["celular"]).ToString("(##) # ####-####");

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

        public Cliente Buscar(int codigo)
        {
            Cliente cliente = null;

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = " SELECT * FROM cliente " +
                                          " WHERE codigo = @codigo ";
                    comando.Parameters.AddWithValue("codigo", (int)codigo);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente = new Cliente();
                        cliente.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        cliente.Nome = reader["nome"].ToString();

                        if (reader["telefone"] != null)
                            cliente.Telefone = Convert.ToInt64(reader["telefone"]);
                        if (reader["celular"] != null)
                            cliente.Celular = Convert.ToInt64(reader["celular"]);

                        cliente.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        cliente.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        cliente.situacao = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        cliente.Enderecos = new EnderecoClienteBD().BuscarEnderecosCliente(cliente.Codigo);
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

            return cliente;
        }
        public Cliente BuscarPorContato(long numeroContato)
        {
            Cliente cliente = null;

            using (MySqlConnection conexao =
                   ConexaoBaseDados.getInstancia().getConexao()
                 )
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = @" SELECT * FROM cliente WHERE 
                                             telefone LIKE @numeroContato OR 
                                             celular  LIKE @numeroContato LIMIT 1;";

                    comando.Parameters.AddWithValue("numeroContato", (long)numeroContato);
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente = new Cliente();
                        cliente.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        cliente.Nome = reader["nome"].ToString();

                        if (reader["telefone"] != null)
                            cliente.Telefone = Convert.ToInt64(reader["telefone"]);
                        if (reader["celular"] != null)
                            cliente.Celular = Convert.ToInt64(reader["celular"]);

                        cliente.DtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        cliente.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
                        cliente.situacao = (Status)Convert.ToInt16(reader["situacao"].ToString());
                        cliente.Enderecos = new EnderecoClienteBD().BuscarEnderecosCliente(cliente.Codigo);
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
            return cliente;
        }
    }
}

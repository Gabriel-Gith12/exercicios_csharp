using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComSelect
{
    class ConexaoBD
    {
        /// Privado somente leitura tipo nome recebe nova Instancia
        private readonly static ConexaoBD conexaoBD = new ConexaoBD();

        /// Obtem uma instancia da Conexao
        public static ConexaoBD GetInstancia()
        {
            return conexaoBD;
        }
        /// Retorna a conexao do MySql
        public MySqlConnection GetConexao()
        {
            /// Acessa o arquivo de configuraçao chamada App.config 
            /// e lê a string de conexão.
            string con = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            /// Cria uma conexão com o banco de Dados.
            MySqlConnection conexao = new MySqlConnection(con);

            return conexao;
        }
    }
}

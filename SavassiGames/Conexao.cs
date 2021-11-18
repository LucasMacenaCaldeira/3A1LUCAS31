
using MySql.Data.MySqlClient;
using System.Data;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MySql;


namespace SavassiGames
{
    class Conexao
    {
        MySqlConnector.MySqlConnection conexao;

        private void Conectar()
        {
            string conn = "persist security info = false; server=localhost; database=bd_savassi; user=root; pwd=;";
            conexao = new MySqlConnector.MySqlConnection(conn);
            conexao.Open();
        }

        public void ExecutarComando(string sql)
        {
            Conectar();
            MySqlConnector.MySqlCommand comando = new MySqlConnector.MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ExecutarConsulta(string sql)
        {
            Conectar();

            DataTable dt = new DataTable();
            MySqlConnector.MySqlDataAdapter dados = new MySqlConnector.MySqlDataAdapter(sql, conexao);

            dados.Fill(dt);
            conexao.Close();
            return dt;

        }
        public DataTable ConsultarDados(string sql)
        {

            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlConnector.MySqlDataAdapter da = new MySqlConnector.MySqlDataAdapter(sql, conexao);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}

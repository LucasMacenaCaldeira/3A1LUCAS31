using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace SavassiGames
{
    class Login
    {
        private static string nome;
        private static string tipo;
        

        public bool ValidarUsuario(string usuario, string senha)
        {
            Conexao bd = new Conexao();
            string sql = string.Format("select * from usuario where usuario = '{0}' and senha = '{1}'",usuario,senha);
            DataTable dt = new DataTable();
            dt = bd.ConsultarDados(sql);

            if(dt.Rows.Count > 0)
            {

                nome = dt.Rows[0]["nome"].ToString();
                tipo = dt.Rows[0]["tipo"].ToString();

                return true;

            }
            else
            {

                return false;

            }
        }

        public string UsuarioLogado()
        {

            return nome;


        }

             public string TipoUsuario()
        {

            return tipo;

        }


    }


    

}

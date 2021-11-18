using System;
using System.Collections.Generic;
using System.Text;
using SavassiGames.DTO;
using SavassiGames.BLL;
using System.Data;

namespace SavassiGames.BLL
{
    class LoginBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where Usuario='lucas' and Senha='123';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace SavassiGames
{
    class Jogos
    {
        public int codigo;
        public string jogo, vendedor;
        

         Conexao objBD = new Conexao();
        string tabela = "tbl_registros";

        public void InserirJogo()
        {
            string inserir = $"INSERT INTO {tabela} (`codigo`, `jogo`, `vendedor`)  VALUES (null, '{jogo}', '{vendedor}');";
            objBD.ExecutarComando(inserir); 
        }

        public void AlterarJogo()
        {
            string alterar = $@"UPDATE {tabela} SET     jogo        = '{jogo}', 
                                                        vendedor         = '{vendedor}' 
          
                                                WHERE   codigo           = '{codigo}';";
            objBD.ExecutarComando(alterar);
        }

        public void ExcluirJogo()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objBD.ExecutarComando(excluir);
        }

        public DataTable ListarJogos()
        {
            string query = $"SELECT * FROM {tabela} ORDER BY codigo;";
            return objBD.ExecutarConsulta(query);
        }
    }
}

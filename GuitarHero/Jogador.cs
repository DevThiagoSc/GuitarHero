using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    class Jogador
    {
        BD bd = new BD();
        SqlDataReader objDados;
        StringBuilder strQuery = new StringBuilder();
        string sqlcmd;

        List<string> jogadoresList = new List<string>();

        private int idJogador;
        private String nomeJogador;
        private int pontuacao;

        public Jogador()
        {

        }

        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }

        public List<string> getJogadores()
        {
            strQuery.Append("Select nome_jogador from jogador;");
            objDados = bd.RetornaDataSet(strQuery.ToString());

            while (objDados.Read())
            {
                jogadoresList.Add(objDados["nome_jogador"].ToString());    
            }
            if (!objDados.IsClosed) { objDados.Close(); strQuery.Remove(0, strQuery.Length); }

            return jogadoresList;
        }

        public void addJogador(string nomeJogador)
        {
            sqlcmd = "Insert into jogador (nome_jogador, pontuacao)" +
                "values(";
            sqlcmd += "'" + nomeJogador + "',";
            sqlcmd += "0);";

            bd.ExecutaComando(sqlcmd);
        }
    }
}

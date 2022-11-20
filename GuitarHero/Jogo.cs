
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    internal class Jogo
    {
        BD bd = new BD();
        SqlDataReader objDados;
        StringBuilder strQuery = new StringBuilder();
        string sqlcmd;

        private int idJogo;
        private int pontuacao;
        private int idJogador;
        private int idMusica;

        public Jogo()
        {
        }

        public int IdJogo { get => idJogo; set => idJogo = value; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int IdMusica { get => idMusica; set => idMusica = value; }

        public void addJogo(int idJogador)
        {
            sqlcmd = "Insert into jogo (id_jogador, id_musica)" +
                "values(";
            sqlcmd += "'" + idJogador + "',";
            sqlcmd += "1);";

            bd.ExecutaComando(sqlcmd);
        }
    }
}

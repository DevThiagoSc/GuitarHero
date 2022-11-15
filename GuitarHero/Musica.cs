using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarHero
{
    internal class Musica
    {
        BD bd = new BD();
        SqlDataReader objDados;
        StringBuilder strQuery = new StringBuilder();
        string sqlcmd;

        private int idMusica;
        private string nameMusica;
        private string banda;

        public Musica()
        {
        }

        public int IdMusica { get => idMusica; set => idMusica = value; }
        public string NameMusica { get => nameMusica; set => nameMusica = value; }
        public string Banda { get => banda; set => banda = value; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarHero
{
    public partial class frmMenu : Form
    {
        BD bd = new BD();
        int idJogador, idMusica;

        public void listarMusica()
        {
            SqlDataReader objDados;
            StringBuilder strQuery = new StringBuilder();

            strQuery.Append("Select nome_musica, banda from musica");
            objDados = bd.RetornaDataSet(strQuery.ToString());
            while (objDados.Read())
            {
                dgvMusicas.Rows.Add(objDados["nome_musica"].ToString(),
                                  objDados["banda"].ToString());
            }
            if (!objDados.IsClosed) { objDados.Close(); strQuery.Remove(0, strQuery.Length); }
        }
        public frmMenu()
        {
            InitializeComponent();
            listarMusica();
            lblJogador.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            FrmJogo jg = new FrmJogo();
            Jogo jogo = new Jogo();

            idJogador = (int)cbxJogador.SelectedValue;
            jogo.addJogo(idJogador);

            jg.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'guitar_ArenaDataSet1.jogador'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadorTableAdapter1.Fill(this.guitar_ArenaDataSet1.jogador);
            // TODO: esta linha de código carrega dados na tabela 'guitar_ArenaDataSet.jogador'. Você pode movê-la ou removê-la conforme necessário.
            this.jogadorTableAdapter.Fill(this.guitar_ArenaDataSet.jogador);

        }
    }
}

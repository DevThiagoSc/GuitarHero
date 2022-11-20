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
    public partial class FrmPrincipal : Form
    {
        BD bd = new BD();

        public void preencheRanking()
        {
            SqlDataReader objDados;
            StringBuilder strQuery = new StringBuilder();

            strQuery.Append("Select nome_jogador, pontuacao from jogador order by pontuacao DESC");
            objDados = bd.RetornaDataSet(strQuery.ToString());
            while (objDados.Read())
            {
                dgvRanking.Rows.Add(objDados["nome_jogador"].ToString(),
                                  objDados["pontuacao"].ToString());
            }
            if (!objDados.IsClosed) { objDados.Close(); strQuery.Remove(0, strQuery.Length); }
        }

        public FrmPrincipal()
        {
            InitializeComponent();
            preencheRanking();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmRegistroJogador rj = new FrmRegistroJogador();
            rj.Show();
            dgvRanking.Refresh();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.Show();
        }
    }
}

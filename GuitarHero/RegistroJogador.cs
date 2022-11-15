using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarHero
{
    public partial class FrmRegistroJogador : Form
    {
        public FrmRegistroJogador()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Jogador jg = new Jogador();
            Form1 frmPrincipal = new Form1();

            jg.addJogador(tbxNome.Text);
            frmPrincipal.Refresh();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

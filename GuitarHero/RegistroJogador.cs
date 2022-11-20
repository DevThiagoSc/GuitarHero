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
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            jg.addJogador(tbxNome.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

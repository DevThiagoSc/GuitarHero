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
    public partial class FrmJogo : Form
    {
        int pontuacaoJogo = 0;
        int peso = 1;
        public FrmJogo()
        {
            InitializeComponent();
            bracoGuitarra.BackColor = Color.FromArgb(125, Color.Black);
            corda1.BackColor = Color.FromArgb(125, Color.Black);
            corda2.BackColor = Color.FromArgb(125, Color.Black);
            corda3.BackColor = Color.FromArgb(125, Color.Black);
            corda4.BackColor = Color.FromArgb(125, Color.Black);
            corda5.BackColor = Color.FromArgb(125, Color.Black);
            pause.BackColor = Color.FromArgb(125, Color.Black);
            Lblpontuacao.Text = pontuacaoJogo.ToString();
        }

        private void btnVerde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                this.btnVerde.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnVerde_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                this.btnVerde.BackColor = System.Drawing.Color.Lime;
            }
        }

        private void btnVermelho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.btnVermelho.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnVermelho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.btnVermelho.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnLaranja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                this.btnAmarelo.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnAmarelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                this.btnAmarelo.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnAmarelo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void btnAzul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                this.btnAzul.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnAzul_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                this.btnAzul.BackColor = System.Drawing.Color.FromArgb(0, 0, 192); 
            }
        }

        private void btnLaranja_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                this.btnLaranja.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnLaranja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                this.btnLaranja.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            }
        }
    }
}

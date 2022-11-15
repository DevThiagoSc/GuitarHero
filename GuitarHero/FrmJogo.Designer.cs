namespace GuitarHero
{
    partial class FrmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bracoGuitarra = new System.Windows.Forms.Panel();
            this.corda5 = new System.Windows.Forms.Panel();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.corda4 = new System.Windows.Forms.Panel();
            this.btnAzul = new System.Windows.Forms.Button();
            this.corda3 = new System.Windows.Forms.Panel();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.corda2 = new System.Windows.Forms.Panel();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.corda1 = new System.Windows.Forms.Panel();
            this.btnVerde = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Panel();
            this.panelPontuacao = new System.Windows.Forms.Panel();
            this.Lblpontuacao = new System.Windows.Forms.Label();
            this.bracoGuitarra.SuspendLayout();
            this.corda5.SuspendLayout();
            this.corda4.SuspendLayout();
            this.corda3.SuspendLayout();
            this.corda2.SuspendLayout();
            this.corda1.SuspendLayout();
            this.panelPontuacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bracoGuitarra
            // 
            this.bracoGuitarra.Controls.Add(this.corda5);
            this.bracoGuitarra.Controls.Add(this.corda4);
            this.bracoGuitarra.Controls.Add(this.corda3);
            this.bracoGuitarra.Controls.Add(this.corda2);
            this.bracoGuitarra.Controls.Add(this.corda1);
            this.bracoGuitarra.Location = new System.Drawing.Point(313, 12);
            this.bracoGuitarra.Name = "bracoGuitarra";
            this.bracoGuitarra.Size = new System.Drawing.Size(317, 423);
            this.bracoGuitarra.TabIndex = 0;
            // 
            // corda5
            // 
            this.corda5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.corda5.Controls.Add(this.btnLaranja);
            this.corda5.Location = new System.Drawing.Point(257, 0);
            this.corda5.Name = "corda5";
            this.corda5.Size = new System.Drawing.Size(60, 422);
            this.corda5.TabIndex = 4;
            // 
            // btnLaranja
            // 
            this.btnLaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaranja.Location = new System.Drawing.Point(4, 381);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(53, 37);
            this.btnLaranja.TabIndex = 2;
            this.btnLaranja.UseVisualStyleBackColor = false;
            this.btnLaranja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLaranja_KeyDown_1);
            this.btnLaranja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnLaranja_KeyUp);
            // 
            // corda4
            // 
            this.corda4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.corda4.Controls.Add(this.btnAzul);
            this.corda4.Location = new System.Drawing.Point(192, 0);
            this.corda4.Name = "corda4";
            this.corda4.Size = new System.Drawing.Size(60, 422);
            this.corda4.TabIndex = 3;
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAzul.Location = new System.Drawing.Point(4, 381);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(53, 37);
            this.btnAzul.TabIndex = 2;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAzul_KeyDown);
            this.btnAzul.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAzul_KeyUp);
            // 
            // corda3
            // 
            this.corda3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.corda3.Controls.Add(this.btnAmarelo);
            this.corda3.Location = new System.Drawing.Point(128, 1);
            this.corda3.Name = "corda3";
            this.corda3.Size = new System.Drawing.Size(60, 422);
            this.corda3.TabIndex = 2;
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.Location = new System.Drawing.Point(4, 381);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(53, 37);
            this.btnAmarelo.TabIndex = 2;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAmarelo_KeyDown);
            this.btnAmarelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAmarelo_KeyUp);
            // 
            // corda2
            // 
            this.corda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.corda2.Controls.Add(this.btnVermelho);
            this.corda2.Location = new System.Drawing.Point(64, 0);
            this.corda2.Name = "corda2";
            this.corda2.Size = new System.Drawing.Size(60, 422);
            this.corda2.TabIndex = 1;
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.Location = new System.Drawing.Point(4, 382);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(53, 37);
            this.btnVermelho.TabIndex = 1;
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVermelho_KeyDown);
            this.btnVermelho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnVermelho_KeyUp);
            // 
            // corda1
            // 
            this.corda1.BackColor = System.Drawing.Color.PaleGreen;
            this.corda1.Controls.Add(this.btnVerde);
            this.corda1.Location = new System.Drawing.Point(1, 1);
            this.corda1.Name = "corda1";
            this.corda1.Size = new System.Drawing.Size(60, 422);
            this.corda1.TabIndex = 0;
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Lime;
            this.btnVerde.Location = new System.Drawing.Point(4, 382);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(53, 37);
            this.btnVerde.TabIndex = 0;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            this.btnVerde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnVerde_KeyDown);
            this.btnVerde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnVerde_KeyUp_1);
            // 
            // pause
            // 
            this.pause.BackgroundImage = global::GuitarHero.Properties.Resources.pause_button_48px;
            this.pause.Location = new System.Drawing.Point(858, 13);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(49, 47);
            this.pause.TabIndex = 1;
            // 
            // panelPontuacao
            // 
            this.panelPontuacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPontuacao.Controls.Add(this.Lblpontuacao);
            this.panelPontuacao.Location = new System.Drawing.Point(762, 379);
            this.panelPontuacao.Name = "panelPontuacao";
            this.panelPontuacao.Size = new System.Drawing.Size(132, 51);
            this.panelPontuacao.TabIndex = 2;
            // 
            // Lblpontuacao
            // 
            this.Lblpontuacao.AutoSize = true;
            this.Lblpontuacao.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpontuacao.ForeColor = System.Drawing.Color.White;
            this.Lblpontuacao.Location = new System.Drawing.Point(24, 7);
            this.Lblpontuacao.Name = "Lblpontuacao";
            this.Lblpontuacao.Size = new System.Drawing.Size(0, 36);
            this.Lblpontuacao.TabIndex = 0;
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuitarHero.Properties.Resources.pexels_thibault_trillet_167636__1_1;
            this.ClientSize = new System.Drawing.Size(919, 447);
            this.Controls.Add(this.panelPontuacao);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.bracoGuitarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJogo";
            this.Text = "FrmJogo";
            this.bracoGuitarra.ResumeLayout(false);
            this.corda5.ResumeLayout(false);
            this.corda4.ResumeLayout(false);
            this.corda3.ResumeLayout(false);
            this.corda2.ResumeLayout(false);
            this.corda1.ResumeLayout(false);
            this.panelPontuacao.ResumeLayout(false);
            this.panelPontuacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bracoGuitarra;
        private System.Windows.Forms.Panel corda3;
        private System.Windows.Forms.Panel corda2;
        private System.Windows.Forms.Panel corda1;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Panel pause;
        private System.Windows.Forms.Panel corda5;
        private System.Windows.Forms.Button btnLaranja;
        private System.Windows.Forms.Panel corda4;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Panel panelPontuacao;
        private System.Windows.Forms.Label Lblpontuacao;
    }
}
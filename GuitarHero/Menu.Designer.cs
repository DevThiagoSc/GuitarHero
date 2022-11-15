namespace GuitarHero
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.btnJogar = new System.Windows.Forms.Button();
            this.cbxJogador = new System.Windows.Forms.ComboBox();
            this.jogadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guitar_ArenaDataSet1 = new GuitarHero.Guitar_ArenaDataSet1();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitar_ArenaDataSet = new GuitarHero.Guitar_ArenaDataSet();
            this.lblJogador = new System.Windows.Forms.Label();
            this.jogadorTableAdapter = new GuitarHero.Guitar_ArenaDataSetTableAdapters.jogadorTableAdapter();
            this.jogadorTableAdapter1 = new GuitarHero.Guitar_ArenaDataSet1TableAdapters.jogadorTableAdapter();
            this.MusicaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_ArenaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_ArenaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusicas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvMusicas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusicas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMusicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusicaColumn,
            this.bandaColumn});
            this.dgvMusicas.EnableHeadersVisualStyles = false;
            this.dgvMusicas.Location = new System.Drawing.Point(337, 66);
            this.dgvMusicas.Name = "dgvMusicas";
            this.dgvMusicas.RowHeadersVisible = false;
            this.dgvMusicas.Size = new System.Drawing.Size(243, 329);
            this.dgvMusicas.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Gray;
            this.btnJogar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnJogar.Location = new System.Drawing.Point(714, 353);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(209, 81);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // cbxJogador
            // 
            this.cbxJogador.DataSource = this.jogadorBindingSource1;
            this.cbxJogador.DisplayMember = "nome_jogador";
            this.cbxJogador.FormattingEnabled = true;
            this.cbxJogador.Location = new System.Drawing.Point(52, 66);
            this.cbxJogador.Name = "cbxJogador";
            this.cbxJogador.Size = new System.Drawing.Size(144, 21);
            this.cbxJogador.TabIndex = 3;
            this.cbxJogador.ValueMember = "id_jogador";
            // 
            // jogadorBindingSource1
            // 
            this.jogadorBindingSource1.DataMember = "jogador";
            this.jogadorBindingSource1.DataSource = this.guitar_ArenaDataSet1;
            // 
            // guitar_ArenaDataSet1
            // 
            this.guitar_ArenaDataSet1.DataSetName = "Guitar_ArenaDataSet1";
            this.guitar_ArenaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataMember = "jogador";
            this.jogadorBindingSource.DataSource = this.guitar_ArenaDataSet;
            // 
            // guitar_ArenaDataSet
            // 
            this.guitar_ArenaDataSet.DataSetName = "Guitar_ArenaDataSet";
            this.guitar_ArenaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.White;
            this.lblJogador.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(52, 43);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(60, 20);
            this.lblJogador.TabIndex = 4;
            this.lblJogador.Text = "Jogador";
            // 
            // jogadorTableAdapter
            // 
            this.jogadorTableAdapter.ClearBeforeFill = true;
            // 
            // jogadorTableAdapter1
            // 
            this.jogadorTableAdapter1.ClearBeforeFill = true;
            // 
            // MusicaColumn
            // 
            this.MusicaColumn.HeaderText = "Música";
            this.MusicaColumn.Name = "MusicaColumn";
            this.MusicaColumn.ReadOnly = true;
            this.MusicaColumn.Width = 142;
            // 
            // bandaColumn
            // 
            this.bandaColumn.HeaderText = "banda";
            this.bandaColumn.Name = "bandaColumn";
            this.bandaColumn.ReadOnly = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuitarHero.Properties.Resources.pexels_freestocksorg_97181__3_;
            this.ClientSize = new System.Drawing.Size(935, 446);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.cbxJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.dgvMusicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_ArenaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_ArenaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ComboBox cbxJogador;
        private System.Windows.Forms.Label lblJogador;
        private Guitar_ArenaDataSet guitar_ArenaDataSet;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private Guitar_ArenaDataSetTableAdapters.jogadorTableAdapter jogadorTableAdapter;
        private Guitar_ArenaDataSet1 guitar_ArenaDataSet1;
        private System.Windows.Forms.BindingSource jogadorBindingSource1;
        private Guitar_ArenaDataSet1TableAdapters.jogadorTableAdapter jogadorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaColumn;
    }
}
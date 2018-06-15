﻿namespace Patronum.Grafico
{
    partial class TelaListaPatrimonios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaPatrimonios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.dgPatrimonios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAquisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoGarant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(93, 12);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(174, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(358, 11);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(100, 20);
            this.tbFiltro.TabIndex = 8;
            this.tbFiltro.Enter += new System.EventHandler(this.tbFiltro_Enter);
            this.tbFiltro.Leave += new System.EventHandler(this.tbFiltro_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btFiltro
            // 
            this.btFiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btFiltro.Location = new System.Drawing.Point(464, 9);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 0;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            // 
            // dgPatrimonios
            // 
            this.dgPatrimonios.AllowUserToAddRows = false;
            this.dgPatrimonios.AllowUserToDeleteRows = false;
            this.dgPatrimonios.AllowUserToOrderColumns = true;
            this.dgPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Setor,
            this.Gestor,
            this.Nfe,
            this.DataAquisi,
            this.PrazoGarant,
            this.Ativo,
            this.Obs});
            this.dgPatrimonios.Location = new System.Drawing.Point(12, 42);
            this.dgPatrimonios.Name = "dgPatrimonios";
            this.dgPatrimonios.ReadOnly = true;
            this.dgPatrimonios.Size = new System.Drawing.Size(1900, 1008);
            this.dgPatrimonios.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Format = "00000";
            dataGridViewCellStyle1.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.FillWeight = 62.80566F;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 65;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 62.80566F;
            this.Nome.HeaderText = "Nome do Patrimônio";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 116;
            // 
            // Setor
            // 
            this.Setor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Setor.DataPropertyName = "Setor";
            this.Setor.FillWeight = 62.80566F;
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            this.Setor.Width = 57;
            // 
            // Gestor
            // 
            this.Gestor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gestor.DataPropertyName = "Gestor";
            this.Gestor.FillWeight = 62.80566F;
            this.Gestor.HeaderText = "Gestor do Setor";
            this.Gestor.Name = "Gestor";
            this.Gestor.ReadOnly = true;
            this.Gestor.Width = 75;
            // 
            // Nfe
            // 
            this.Nfe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nfe.DataPropertyName = "Nfe";
            this.Nfe.FillWeight = 62.80566F;
            this.Nfe.HeaderText = "Nota Fiscal";
            this.Nfe.Name = "Nfe";
            this.Nfe.ReadOnly = true;
            this.Nfe.Width = 78;
            // 
            // DataAquisi
            // 
            this.DataAquisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataAquisi.DataPropertyName = "DataAquisi";
            this.DataAquisi.FillWeight = 62.80566F;
            this.DataAquisi.HeaderText = "Data de Aquisição";
            this.DataAquisi.Name = "DataAquisi";
            this.DataAquisi.ReadOnly = true;
            this.DataAquisi.Width = 109;
            // 
            // PrazoGarant
            // 
            this.PrazoGarant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrazoGarant.DataPropertyName = "PrazoGarant";
            this.PrazoGarant.FillWeight = 62.80566F;
            this.PrazoGarant.HeaderText = "Prazo de Garantia";
            this.PrazoGarant.Name = "PrazoGarant";
            this.PrazoGarant.ReadOnly = true;
            this.PrazoGarant.Width = 107;
            // 
            // Ativo
            // 
            this.Ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ativo.DataPropertyName = "ckAtivo";
            this.Ativo.HeaderText = "Está ativo ?";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ativo.Width = 73;
            // 
            // Obs
            // 
            this.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Obs.DataPropertyName = "Obs";
            this.Obs.HeaderText = "Observações";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            this.Obs.Width = 95;
            // 
            // TelaListaPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.dgPatrimonios);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaListaPatrimonios";
            this.Text = "Lista de Patrimônios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaPatrimonios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.DataGridView dgPatrimonios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAquisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoGarant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
    }
}
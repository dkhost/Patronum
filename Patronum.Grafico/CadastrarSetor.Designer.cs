namespace Patronum.Grafico
{
    partial class ManterSetor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterSetor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeSetor = new System.Windows.Forms.TextBox();
            this.tbNomeGestor = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgSetores = new System.Windows.Forms.DataGridView();
            this.NomeSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemover = new System.Windows.Forms.Button();
            this.tbFiltroSetores = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFiltro = new System.Windows.Forms.Button();
            this.btRecarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSetores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Gestor:";
            // 
            // tbNomeSetor
            // 
            this.tbNomeSetor.Location = new System.Drawing.Point(110, 12);
            this.tbNomeSetor.Name = "tbNomeSetor";
            this.tbNomeSetor.Size = new System.Drawing.Size(347, 20);
            this.tbNomeSetor.TabIndex = 2;
            // 
            // tbNomeGestor
            // 
            this.tbNomeGestor.Location = new System.Drawing.Point(110, 38);
            this.tbNomeGestor.Name = "tbNomeGestor";
            this.tbNomeGestor.Size = new System.Drawing.Size(347, 20);
            this.tbNomeGestor.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(535, 327);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Adicionar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(456, 327);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dgSetores
            // 
            this.dgSetores.AllowUserToAddRows = false;
            this.dgSetores.AllowUserToDeleteRows = false;
            this.dgSetores.AllowUserToOrderColumns = true;
            this.dgSetores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSetores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSetores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSetores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeSetor,
            this.NomeGestor});
            this.dgSetores.Location = new System.Drawing.Point(12, 64);
            this.dgSetores.Name = "dgSetores";
            this.dgSetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSetores.Size = new System.Drawing.Size(600, 256);
            this.dgSetores.TabIndex = 6;
            // 
            // NomeSetor
            // 
            this.NomeSetor.DataPropertyName = "NomeSetor";
            this.NomeSetor.HeaderText = "Nome do Setor";
            this.NomeSetor.Name = "NomeSetor";
            // 
            // NomeGestor
            // 
            this.NomeGestor.DataPropertyName = "NomeGestor";
            this.NomeGestor.HeaderText = "Nome do Gestor";
            this.NomeGestor.Name = "NomeGestor";
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(535, 23);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // tbFiltroSetores
            // 
            this.tbFiltroSetores.Location = new System.Drawing.Point(45, 329);
            this.tbFiltroSetores.Name = "tbFiltroSetores";
            this.tbFiltroSetores.Size = new System.Drawing.Size(123, 20);
            this.tbFiltroSetores.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(174, 327);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(75, 23);
            this.tbFiltro.TabIndex = 11;
            this.tbFiltro.Text = "Filtrar";
            this.tbFiltro.UseVisualStyleBackColor = true;
            this.tbFiltro.Click += new System.EventHandler(this.tbFiltroSetores_Click);
            // 
            // btRecarregar
            // 
            this.btRecarregar.Location = new System.Drawing.Point(255, 327);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(75, 23);
            this.btRecarregar.TabIndex = 12;
            this.btRecarregar.Text = "Recarregar";
            this.btRecarregar.UseVisualStyleBackColor = true;
            this.btRecarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManterSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btRecarregar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFiltroSetores);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.dgSetores);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbNomeGestor);
            this.Controls.Add(this.tbNomeSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "ManterSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes do Setor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManterSetor_FormClosed);
            this.Load += new System.EventHandler(this.ManterSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSetores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeSetor;
        private System.Windows.Forms.TextBox tbNomeGestor;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dgSetores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGestor;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbFiltroSetores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tbFiltro;
        private System.Windows.Forms.Button btRecarregar;
    }
}
namespace Patronum.Grafico
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.NomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.tbFiltroFornecedor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Fornecedor:";
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Location = new System.Drawing.Point(113, 6);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(158, 20);
            this.tbFornecedor.TabIndex = 1;
            // 
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AllowUserToDeleteRows = false;
            this.dgFornecedores.AllowUserToOrderColumns = true;
            this.dgFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFornecedor});
            this.dgFornecedores.Location = new System.Drawing.Point(15, 32);
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.Size = new System.Drawing.Size(597, 289);
            this.dgFornecedores.TabIndex = 2;
            // 
            // NomeFornecedor
            // 
            this.NomeFornecedor.DataPropertyName = "NomeFornecedor";
            this.NomeFornecedor.HeaderText = "Nome do Fornecedor";
            this.NomeFornecedor.Name = "NomeFornecedor";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(537, 327);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(537, 4);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // tbFiltroFornecedor
            // 
            this.tbFiltroFornecedor.Location = new System.Drawing.Point(45, 329);
            this.tbFiltroFornecedor.Name = "tbFiltroFornecedor";
            this.tbFiltroFornecedor.Size = new System.Drawing.Size(100, 20);
            this.tbFiltroFornecedor.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(151, 327);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 12;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // btRecarregar
            // 
            this.btRecarregar.Location = new System.Drawing.Point(232, 327);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(75, 23);
            this.btRecarregar.TabIndex = 13;
            this.btRecarregar.Text = "Recarregar";
            this.btRecarregar.UseVisualStyleBackColor = true;
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(277, 4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 14;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btRecarregar);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFiltroFornecedor);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.dgFornecedores);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "CadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes do Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastrarFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.TextBox tbFiltroFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFornecedor;
    }
}
namespace Patronum.Grafico
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgPatrimonios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAquisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrazoGarant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // dgPatrimonios
            // 
            this.dgPatrimonios.AllowUserToDeleteRows = false;
            this.dgPatrimonios.AllowUserToOrderColumns = true;
            this.dgPatrimonios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Setor,
            this.Gestor,
            this.Fornecedor,
            this.Nfe,
            this.ServiceTag,
            this.DataAquisi,
            this.PrazoGarant,
            this.Obs});
            this.dgPatrimonios.Location = new System.Drawing.Point(12, 41);
            this.dgPatrimonios.Name = "dgPatrimonios";
            this.dgPatrimonios.ReadOnly = true;
            this.dgPatrimonios.Size = new System.Drawing.Size(1379, 875);
            this.dgPatrimonios.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Patrimônio";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Setor
            // 
            this.Setor.DataPropertyName = "Setor";
            this.Setor.HeaderText = "Setor";
            this.Setor.Name = "Setor";
            this.Setor.ReadOnly = true;
            // 
            // Gestor
            // 
            this.Gestor.DataPropertyName = "Gestor";
            this.Gestor.HeaderText = "Gestor";
            this.Gestor.Name = "Gestor";
            this.Gestor.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // Nfe
            // 
            this.Nfe.DataPropertyName = "Nfe";
            this.Nfe.HeaderText = "Nota Fiscal";
            this.Nfe.Name = "Nfe";
            this.Nfe.ReadOnly = true;
            // 
            // ServiceTag
            // 
            this.ServiceTag.DataPropertyName = "ServiceTag";
            this.ServiceTag.HeaderText = "ServiceTag";
            this.ServiceTag.Name = "ServiceTag";
            this.ServiceTag.ReadOnly = true;
            // 
            // DataAquisi
            // 
            this.DataAquisi.DataPropertyName = "DataAquisi";
            this.DataAquisi.HeaderText = "Data de Aquisição";
            this.DataAquisi.Name = "DataAquisi";
            this.DataAquisi.ReadOnly = true;
            // 
            // PrazoGarant
            // 
            this.PrazoGarant.DataPropertyName = "PrazoGarant";
            this.PrazoGarant.HeaderText = "Prazo de Garantia";
            this.PrazoGarant.Name = "PrazoGarant";
            this.PrazoGarant.ReadOnly = true;
            // 
            // Obs
            // 
            this.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Obs.DataPropertyName = "Obs";
            this.Obs.HeaderText = "Observações";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            // 
            // TelaListaPatrimonios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 928);
            this.Controls.Add(this.dgPatrimonios);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TelaListaPatrimonios";
            this.Text = "Lista de Patrimônios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaPatrimonios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgPatrimonios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAquisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrazoGarant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaPatrimonios));
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.dgPatrimonios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAquisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoGarantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patrimoniosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patronumdbDataSet = new Patronum.Grafico.PatronumdbDataSet();
            this.patronumdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patrimoniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patrimoniosTableAdapter = new Patronum.Grafico.PatronumdbDataSetTableAdapters.PatrimoniosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatrimonios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource)).BeginInit();
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
            this.dgPatrimonios.AutoGenerateColumns = false;
            this.dgPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.gestorDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.dataAquisiDataGridViewTextBoxColumn,
            this.prazoGarantDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn});
            this.dgPatrimonios.DataSource = this.patrimoniosBindingSource1;
            this.dgPatrimonios.Location = new System.Drawing.Point(12, 42);
            this.dgPatrimonios.Name = "dgPatrimonios";
            this.dgPatrimonios.ReadOnly = true;
            this.dgPatrimonios.Size = new System.Drawing.Size(1900, 1008);
            this.dgPatrimonios.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Patrimônio";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "Setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gestorDataGridViewTextBoxColumn
            // 
            this.gestorDataGridViewTextBoxColumn.DataPropertyName = "Gestor";
            this.gestorDataGridViewTextBoxColumn.HeaderText = "Gestor";
            this.gestorDataGridViewTextBoxColumn.Name = "gestorDataGridViewTextBoxColumn";
            this.gestorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAquisiDataGridViewTextBoxColumn
            // 
            this.dataAquisiDataGridViewTextBoxColumn.DataPropertyName = "DataAquisi";
            this.dataAquisiDataGridViewTextBoxColumn.HeaderText = "DataAquisi";
            this.dataAquisiDataGridViewTextBoxColumn.Name = "dataAquisiDataGridViewTextBoxColumn";
            this.dataAquisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prazoGarantDataGridViewTextBoxColumn
            // 
            this.prazoGarantDataGridViewTextBoxColumn.DataPropertyName = "PrazoGarant";
            this.prazoGarantDataGridViewTextBoxColumn.HeaderText = "PrazoGarant";
            this.prazoGarantDataGridViewTextBoxColumn.Name = "prazoGarantDataGridViewTextBoxColumn";
            this.prazoGarantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patrimoniosBindingSource1
            // 
            this.patrimoniosBindingSource1.DataMember = "Patrimonios";
            this.patrimoniosBindingSource1.DataSource = this.patronumdbDataSet;
            // 
            // patronumdbDataSet
            // 
            this.patronumdbDataSet.DataSetName = "PatronumdbDataSet";
            this.patronumdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronumdbDataSetBindingSource
            // 
            this.patronumdbDataSetBindingSource.DataSource = this.patronumdbDataSet;
            this.patronumdbDataSetBindingSource.Position = 0;
            // 
            // patrimoniosBindingSource
            // 
            this.patrimoniosBindingSource.DataMember = "Patrimonios";
            this.patrimoniosBindingSource.DataSource = this.patronumdbDataSetBindingSource;
            // 
            // patrimoniosTableAdapter
            // 
            this.patrimoniosTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource patronumdbDataSetBindingSource;
        private PatronumdbDataSet patronumdbDataSet;
        private System.Windows.Forms.BindingSource patrimoniosBindingSource;
        private PatronumdbDataSetTableAdapters.PatrimoniosTableAdapter patrimoniosTableAdapter;
        private System.Windows.Forms.BindingSource patrimoniosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAquisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoGarantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
    }
}
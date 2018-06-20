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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgSetores = new System.Windows.Forms.DataGridView();
            this.NomeSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeGestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSetores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Gestor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(371, 74);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(281, 74);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // dgSetores
            // 
            this.dgSetores.AllowUserToAddRows = false;
            this.dgSetores.AllowUserToDeleteRows = false;
            this.dgSetores.AllowUserToOrderColumns = true;
            this.dgSetores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSetores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSetores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSetores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeSetor,
            this.NomeGestor});
            this.dgSetores.Location = new System.Drawing.Point(12, 114);
            this.dgSetores.Name = "dgSetores";
            this.dgSetores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSetores.Size = new System.Drawing.Size(760, 435);
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
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(16, 74);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Detalhes";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(100, 74);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // ManterSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgSetores);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManterSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Setor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManterSetor_FormClosed);
            this.Load += new System.EventHandler(this.ManterSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSetores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dgSetores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeGestor;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
    }
}
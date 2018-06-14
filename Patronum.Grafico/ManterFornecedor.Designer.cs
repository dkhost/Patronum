namespace Patronum.Grafico
{
    partial class ManterFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.btCancela = new System.Windows.Forms.Button();
            this.btSalvaFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Fornecedor:";
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Location = new System.Drawing.Point(125, 54);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(100, 20);
            this.tbFornecedor.TabIndex = 1;
            // 
            // btCancela
            // 
            this.btCancela.Location = new System.Drawing.Point(15, 107);
            this.btCancela.Name = "btCancela";
            this.btCancela.Size = new System.Drawing.Size(75, 23);
            this.btCancela.TabIndex = 6;
            this.btCancela.Text = "Cancelar";
            this.btCancela.UseVisualStyleBackColor = true;
            this.btCancela.Click += new System.EventHandler(this.btCancela_Click);
            // 
            // btSalvaFornecedor
            // 
            this.btSalvaFornecedor.Location = new System.Drawing.Point(152, 107);
            this.btSalvaFornecedor.Name = "btSalvaFornecedor";
            this.btSalvaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btSalvaFornecedor.TabIndex = 7;
            this.btSalvaFornecedor.Text = "Salvar";
            this.btSalvaFornecedor.UseVisualStyleBackColor = true;
            this.btSalvaFornecedor.Click += new System.EventHandler(this.btSalvaFornecedor_Click);
            // 
            // ManterFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 142);
            this.Controls.Add(this.btSalvaFornecedor);
            this.Controls.Add(this.btCancela);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManterFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.Button btCancela;
        private System.Windows.Forms.Button btSalvaFornecedor;
    }
}
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
            this.btSalvarSetor = new System.Windows.Forms.Button();
            this.btCancelarSetor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestor do Setor:";
            // 
            // tbNomeSetor
            // 
            this.tbNomeSetor.Location = new System.Drawing.Point(99, 23);
            this.tbNomeSetor.Name = "tbNomeSetor";
            this.tbNomeSetor.Size = new System.Drawing.Size(100, 20);
            this.tbNomeSetor.TabIndex = 2;
            // 
            // tbNomeGestor
            // 
            this.tbNomeGestor.Location = new System.Drawing.Point(99, 56);
            this.tbNomeGestor.Name = "tbNomeGestor";
            this.tbNomeGestor.Size = new System.Drawing.Size(100, 20);
            this.tbNomeGestor.TabIndex = 3;
            // 
            // btSalvarSetor
            // 
            this.btSalvarSetor.Location = new System.Drawing.Point(124, 110);
            this.btSalvarSetor.Name = "btSalvarSetor";
            this.btSalvarSetor.Size = new System.Drawing.Size(75, 23);
            this.btSalvarSetor.TabIndex = 4;
            this.btSalvarSetor.Text = "Salvar";
            this.btSalvarSetor.UseVisualStyleBackColor = true;
            this.btSalvarSetor.Click += new System.EventHandler(this.btSalvarSetor_Click);
            // 
            // btCancelarSetor
            // 
            this.btCancelarSetor.Location = new System.Drawing.Point(16, 110);
            this.btCancelarSetor.Name = "btCancelarSetor";
            this.btCancelarSetor.Size = new System.Drawing.Size(75, 23);
            this.btCancelarSetor.TabIndex = 5;
            this.btCancelarSetor.Text = "Cancelar";
            this.btCancelarSetor.UseVisualStyleBackColor = true;
            this.btCancelarSetor.Click += new System.EventHandler(this.btCancelarSetor_Click);
            // 
            // ManterSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(234, 142);
            this.Controls.Add(this.btCancelarSetor);
            this.Controls.Add(this.btSalvarSetor);
            this.Controls.Add(this.tbNomeGestor);
            this.Controls.Add(this.tbNomeSetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManterSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Setor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeSetor;
        private System.Windows.Forms.TextBox tbNomeGestor;
        private System.Windows.Forms.Button btSalvarSetor;
        private System.Windows.Forms.Button btCancelarSetor;
    }
}
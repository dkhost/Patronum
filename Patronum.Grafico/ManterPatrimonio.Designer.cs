using System;

namespace Patronum.Grafico
{
    partial class ManterPatrimonio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterPatrimonio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDataAquisi = new System.Windows.Forms.TextBox();
            this.tbPrazoGarant = new System.Windows.Forms.TextBox();
            this.tbNfe = new System.Windows.Forms.TextBox();
            this.tbServiceTag = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Observacoes = new System.Windows.Forms.Label();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.cbGestor = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.patrimoniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patronumdbDataSet = new Patronum.Grafico.PatronumdbDataSet();
            this.patrimoniosTableAdapter = new Patronum.Grafico.PatronumdbDataSetTableAdapters.PatrimoniosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Patrimônio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gestor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Aquisição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prazo de Garantia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nota Fiscal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ServiceTag:";
            // 
            // tbNome
            // 
            this.tbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Nome", true));
            this.tbNome.Location = new System.Drawing.Point(119, 34);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(669, 20);
            this.tbNome.TabIndex = 9;
            // 
            // tbDataAquisi
            // 
            this.tbDataAquisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "DataAquisi", true));
            this.tbDataAquisi.Location = new System.Drawing.Point(115, 176);
            this.tbDataAquisi.Name = "tbDataAquisi";
            this.tbDataAquisi.Size = new System.Drawing.Size(100, 20);
            this.tbDataAquisi.TabIndex = 15;
            // 
            // tbPrazoGarant
            // 
            this.tbPrazoGarant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "PrazoGarant", true));
            this.tbPrazoGarant.Location = new System.Drawing.Point(115, 201);
            this.tbPrazoGarant.Name = "tbPrazoGarant";
            this.tbPrazoGarant.Size = new System.Drawing.Size(100, 20);
            this.tbPrazoGarant.TabIndex = 16;
            // 
            // tbNfe
            // 
            this.tbNfe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Nfe", true));
            this.tbNfe.Location = new System.Drawing.Point(82, 129);
            this.tbNfe.Name = "tbNfe";
            this.tbNfe.Size = new System.Drawing.Size(706, 20);
            this.tbNfe.TabIndex = 13;
            // 
            // tbServiceTag
            // 
            this.tbServiceTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "ServiceTag", true));
            this.tbServiceTag.Location = new System.Drawing.Point(82, 152);
            this.tbServiceTag.Name = "tbServiceTag";
            this.tbServiceTag.Size = new System.Drawing.Size(706, 20);
            this.tbServiceTag.TabIndex = 14;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(713, 238);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 19;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(632, 238);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.LightGray;
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Id", true));
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(66, 7);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 21;
            this.tbId.TabStop = false;
            // 
            // tbObs
            // 
            this.tbObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Obs", true));
            this.tbObs.Location = new System.Drawing.Point(115, 227);
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(490, 52);
            this.tbObs.TabIndex = 17;
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Checked = true;
            this.Ativo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ativo.Location = new System.Drawing.Point(192, 10);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(50, 17);
            this.Ativo.TabIndex = 103;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            this.Ativo.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Observacoes
            // 
            this.Observacoes.AutoSize = true;
            this.Observacoes.Location = new System.Drawing.Point(36, 230);
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.Size = new System.Drawing.Size(76, 13);
            this.Observacoes.TabIndex = 104;
            this.Observacoes.Text = "Observações: ";
            // 
            // cbSetor
            // 
            this.cbSetor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Setor", true));
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(66, 57);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(722, 21);
            this.cbSetor.TabIndex = 105;
            this.cbSetor.SelectedIndexChanged += new System.EventHandler(this.cbSetor_SelectedIndexChanged);
            // 
            // cbGestor
            // 
            this.cbGestor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Gestor", true));
            this.cbGestor.FormattingEnabled = true;
            this.cbGestor.Location = new System.Drawing.Point(65, 81);
            this.cbGestor.Name = "cbGestor";
            this.cbGestor.Size = new System.Drawing.Size(723, 21);
            this.cbGestor.TabIndex = 106;
            this.cbGestor.SelectedIndexChanged += new System.EventHandler(this.cbGestor_SelectedIndexChanged);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patrimoniosBindingSource, "Fornecedor", true));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(81, 106);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(707, 21);
            this.cbFornecedor.TabIndex = 107;
            this.cbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbFornecedor_SelectedIndexChanged);
            // 
            // patrimoniosBindingSource
            // 
            this.patrimoniosBindingSource.DataMember = "Patrimonios";
            this.patrimoniosBindingSource.DataSource = this.patronumdbDataSet;
            // 
            // patronumdbDataSet
            // 
            this.patronumdbDataSet.DataSetName = "PatronumdbDataSet";
            this.patronumdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patrimoniosTableAdapter
            // 
            this.patrimoniosTableAdapter.ClearBeforeFill = true;
            // 
            // ManterPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 311);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.cbGestor);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.Observacoes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbServiceTag);
            this.Controls.Add(this.tbNfe);
            this.Controls.Add(this.tbPrazoGarant);
            this.Controls.Add(this.tbDataAquisi);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManterPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Patrimônio";
            this.Shown += new System.EventHandler(this.ManterPatrimonio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.patrimoniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronumdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDataAquisi;
        private System.Windows.Forms.TextBox tbPrazoGarant;
        private System.Windows.Forms.TextBox tbNfe;
        private System.Windows.Forms.TextBox tbServiceTag;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Observacoes;
        private PatronumdbDataSet patronumdbDataSet;
        private PatronumdbDataSetTableAdapters.PatrimoniosTableAdapter patrimoniosTableAdapter;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.ComboBox cbGestor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.BindingSource patrimoniosBindingSource;
    }
}
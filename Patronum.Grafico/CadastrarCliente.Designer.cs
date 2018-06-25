namespace Patronum.Grafico
{
    partial class CadastrarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbSetor = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFechar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbResp = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btCarregar = new System.Windows.Forms.Button();
            this.tbFiltroCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Setor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome da Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(115, 41);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(441, 20);
            this.tbCliente.TabIndex = 3;
            // 
            // tbSetor
            // 
            this.tbSetor.Location = new System.Drawing.Point(115, 67);
            this.tbSetor.Name = "tbSetor";
            this.tbSetor.Size = new System.Drawing.Size(441, 20);
            this.tbSetor.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(115, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(441, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbCnpj
            // 
            this.tbCnpj.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.tbCnpj.Location = new System.Drawing.Point(115, 15);
            this.tbCnpj.Mask = "99.999.999/9999-99";
            this.tbCnpj.Name = "tbCnpj";
            this.tbCnpj.Size = new System.Drawing.Size(441, 20);
            this.tbCnpj.TabIndex = 2;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(115, 93);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(441, 20);
            this.tbEndereco.TabIndex = 5;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(115, 145);
            this.tbTelefone.Mask = "(99) 0000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(441, 20);
            this.tbTelefone.TabIndex = 7;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.Cnpj,
            this.Empresa,
            this.SetorEmpresa,
            this.Endereco,
            this.Email,
            this.Telefone,
            this.Responsavel});
            this.dgClientes.Location = new System.Drawing.Point(15, 214);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(1329, 515);
            this.dgClientes.TabIndex = 16;
            // 
            // ClienteId
            // 
            this.ClienteId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClienteId.DataPropertyName = "ClienteId";
            dataGridViewCellStyle2.Format = "0000";
            dataGridViewCellStyle2.NullValue = "0000";
            this.ClienteId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClienteId.HeaderText = "Código da Empresa";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Width = 114;
            // 
            // Cnpj
            // 
            this.Cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnpj.DataPropertyName = "CNPJ";
            this.Cnpj.HeaderText = "CNPJ";
            this.Cnpj.Name = "Cnpj";
            // 
            // Empresa
            // 
            this.Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empresa.DataPropertyName = "NomeCliente";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // SetorEmpresa
            // 
            this.SetorEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SetorEmpresa.DataPropertyName = "SetorCliente";
            this.SetorEmpresa.HeaderText = "Setor da Empresa";
            this.SetorEmpresa.Name = "SetorEmpresa";
            // 
            // Endereco
            // 
            this.Endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Responsavel.DataPropertyName = "Resp";
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(617, 169);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(75, 23);
            this.btFechar.TabIndex = 9;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(779, 169);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 11;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(698, 169);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 10;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Responsável:";
            // 
            // tbResp
            // 
            this.tbResp.Location = new System.Drawing.Point(115, 171);
            this.tbResp.Name = "tbResp";
            this.tbResp.Size = new System.Drawing.Size(441, 20);
            this.tbResp.TabIndex = 8;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(1085, 91);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 21;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(1166, 91);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(75, 23);
            this.btCarregar.TabIndex = 22;
            this.btCarregar.Text = "Recarregar";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbFiltroCliente
            // 
            this.tbFiltroCliente.Location = new System.Drawing.Point(963, 93);
            this.tbFiltroCliente.Name = "tbFiltroCliente";
            this.tbFiltroCliente.Size = new System.Drawing.Size(116, 20);
            this.tbFiltroCliente.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(930, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filtrar por nome";
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFiltroCliente);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.tbResp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbCnpj);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbSetor);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "CadastrarCliente";
            this.Text = "Detalhes do Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastrarCliente_FormClosed);
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbSetor;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox tbCnpj;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbResp;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.TextBox tbFiltroCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
    }
}
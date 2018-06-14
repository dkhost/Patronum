using Patronum.Negocio;
using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patronum.Grafico
{
    public partial class ManterFornecedor : Form
    {
        public Fornecedor FornecedorSelecionado { get; set; }

        public ManterFornecedor()
        {
            InitializeComponent();
        }

        private void btCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvaFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = tbFornecedor.Text;

            Validacao validacao;

            if (FornecedorSelecionado != null)
            {
                validacao = Program.Gerenciador.CadastrarFornecedor(fornecedor);
            }
            else
            {
                validacao = Program.Gerenciador.CadastrarFornecedor(fornecedor);

            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;

                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!");

            }
            this.Close();
        }
    }
}

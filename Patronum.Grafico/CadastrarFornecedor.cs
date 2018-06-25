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
    public partial class CadastrarFornecedor : Form
    {
        Fornecedor FornecedorSelecionado { get; set; }

        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void CadastrarFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            dgFornecedores.AutoGenerateColumns = false;
            List<Fornecedor> fornecedores = Program.Gerenciador.TodosOsFornecedores();
            dgFornecedores.DataSource = fornecedores;
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            var filtro = tbFiltroFornecedor.Text;
            var fornecedorFiltrado = Program.Gerenciador.TodosOsFornecedores().Where(m => m.NomeFornecedor == filtro).ToList();
            dgFornecedores.DataSource = fornecedorFiltrado;
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover esse Fornecedor da lista ?", "Você está prestes a remover o fornecedor selecionado", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Fornecedor fornecedorSelecionado = (Fornecedor)dgFornecedores.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverFornecedor(fornecedorSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Fornecedor removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover esse setor!");
                    }
                    CarregarFornecedores();
                }
            }
        }

        private bool VerificarSelecao()
        {
            if (dgFornecedores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.NomeFornecedor = tbFornecedor.Text;

            Validacao validacao;

            validacao = Program.Gerenciador.CadastrarFornecedor(fornecedor);

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
            CarregarFornecedores();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

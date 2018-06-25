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
    public partial class CadastrarCliente : Form
    {
        Cliente ClienteSelecionado { get; set; }

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NomeCliente = tbCliente.Text;
            cliente.SetorCliente = tbSetor.Text;
            cliente.Endereco = tbEndereco.Text;
            cliente.CNPJ = tbCnpj.Text;
            cliente.Email = tbEmail.Text;
            cliente.Telefone = tbTelefone.Text;
            cliente.Resp = tbResp.Text;

            Validacao validacao = new Validacao();

            validacao = Program.Gerenciador.CadastrarCliente(cliente);

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
                MessageBox.Show("Cliente cadastrado com sucesso!");

            }
            CarregarClientes();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover esse Cliente da lista ?", "Você está prestes a remover o cliente selecionado", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Cliente clienteSelecionado = (Cliente)dgClientes.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverCliente(clienteSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Cliente removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover esse patrimônio!");
                    }
                    CarregarClientes();
                }
            }
        }

        private void CarregarClientes()
        {
            dgClientes.AutoGenerateColumns = false;
            List<Cliente> clientes = Program.Gerenciador.TodosOsClientes();
            dgClientes.DataSource = clientes;
        }

        private bool VerificarSelecao()
        {
            if (dgClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CadastrarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarClientes();
        }
    }
}

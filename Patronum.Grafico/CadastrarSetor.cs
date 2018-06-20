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
    public partial class ManterSetor : Form
    {
        public ManterSetor()
        {
            InitializeComponent();
        }

        private void ManterSetor_Load(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
            CarregarSetores();
        }

        private void ManterSetor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarSetores();
        }

        private void CarregarSetores()
        {
            dgSetores.AutoGenerateColumns = false;
            List<Setor> setores = Program.Gerenciador.TodosOsSetores();
            dgSetores.DataSource = setores;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();

            setor.NomeSetor = textBox1.Text;
            setor.NomeGestor = textBox2.Text;

            Validacao validacao;

            validacao = Program.Gerenciador.CadastrarSetor(setor);

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
                MessageBox.Show("Setor cadastrado com sucesso!");

            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Setor setorSelecionado = (Setor)dgSetores.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(setorSelecionado);
            }
        }

        private bool VerificarSelecao()
        {
            if (dgSetores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover esse patrimônio da lista ?", "Você está prestes a remover o patrimônio selecionado", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Setor setorSelecionado = (Setor)dgSetores.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverSetor(setorSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Setor removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover esse patrimônio!");
                    }
                    CarregarSetores();
                }
            }
        }
    }
}

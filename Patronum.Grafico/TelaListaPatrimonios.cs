using MySql.Data.MySqlClient;
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
using System.Linq.Dynamic;

namespace Patronum.Grafico
{
    public partial class TelaListaPatrimonios : Form
    {

        public TelaListaPatrimonios()
        {
            InitializeComponent();
        }
        private void AbreTelaInclusaoAlteracao(Patrimonio patrimonioSelecionado)
        {
            ManterPatrimonio tela = new ManterPatrimonio();
            tela.PatrimonioSelecionado = patrimonioSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPatrimonios();
        }

        private void CarregarPatrimonios()
        {
            dgPatrimonios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgPatrimonios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPatrimonios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPatrimonios.AutoGenerateColumns = false;
            List<Patrimonio> patrimonios = Program.Gerenciador.TodosOsPatrimonios();
            dgPatrimonios.DataSource = patrimonios;
        }

        private void TelaListaPatrimonios_Load(object sender, EventArgs e)
        {
            CarregarPatrimonios();
        }

        private bool VerificarSelecao()
        {
            if (dgPatrimonios.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover esse patrimônio da lista ?", "Você está prestes a remover o patrimônio selecionado", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Patrimonio patrimonioSelecionado = (Patrimonio)dgPatrimonios.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPatrimonio(patrimonioSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Patrimônio removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover esse patrimônio!");
                    }
                    CarregarPatrimonios();
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                Patrimonio patrimonioSelecionado = (Patrimonio)dgPatrimonios.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(patrimonioSelecionado);
            }
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            string filtro = tbFiltro.Text;
            var patrimonioFiltrado = Program.Gerenciador.TodosOsPatrimonios().Where(m => m.Nome == filtro).ToList();
            dgPatrimonios.DataSource = patrimonioFiltrado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarPatrimonios();
        }
    }
}

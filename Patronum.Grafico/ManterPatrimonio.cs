using MySql.Data.MySqlClient;
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
    public partial class ManterPatrimonio : Form
    {
        public Patrimonio PatrimonioSelecionado { get; set; }

        public ManterPatrimonio()
        {
            InitializeComponent();
        }

        private void ManterPatrimonio_Load(object sender, EventArgs e)
        {
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            {
                cbTeste.DisplayMember = "Descricao";
                cbTeste.ValueMember = "Fornecedor";
                cbTeste.DataSource = Program.Gerenciador.TodosOsPatrimonios();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Patrimonio patrimonio = new Patrimonio();

            if (Int64.TryParse(tbId.Text, out long value))
            {
                patrimonio.Id = value;
            }
            else
            {
                patrimonio.Id = -1;
            }

            patrimonio.Nome = tbNome.Text;
            patrimonio.Nfe = tbNfe.Text;
            patrimonio.Setor = tbSetor.Text;
            patrimonio.Gestor = tbGestor.Text;
            patrimonio.Fornecedor = tbFornecedor.Text;
            patrimonio.ServiceTag = tbServiceTag.Text;
            patrimonio.DataAquisi = Convert.ToDateTime(tbDataAquisi.Text);
            patrimonio.PrazoGarant = Convert.ToDateTime(tbPrazoGarant.Text);
            patrimonio.Obs = tbObs.Text;
            patrimonio.Ativo = ckbAtivo.Checked;

            Validacao validacao;
            if (PatrimonioSelecionado != null)
            {
                validacao = Program.Gerenciador.AlterarPatrimonio(patrimonio);
            }
            else
            {
                validacao = Program.Gerenciador.CadastrarPatrimonio(patrimonio);

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
                MessageBox.Show("Patrimônio salvo com sucesso!");

            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterPatrimonio_Shown(object sender, EventArgs e)
        {
            if(PatrimonioSelecionado != null)
            {
                this.tbId.Text = PatrimonioSelecionado.Id.ToString();
                this.tbNome.Text = PatrimonioSelecionado.Nome;
                this.tbSetor.Text = PatrimonioSelecionado.Setor;
                this.tbGestor.Text = PatrimonioSelecionado.Gestor;
                this.tbFornecedor.Text = PatrimonioSelecionado.Fornecedor;
                this.tbNfe.Text = PatrimonioSelecionado.Nfe;
                this.tbServiceTag.Text = PatrimonioSelecionado.ServiceTag;
                this.tbDataAquisi.Text = PatrimonioSelecionado.DataAquisi.ToShortDateString();
                this.tbPrazoGarant.Text = PatrimonioSelecionado.PrazoGarant.ToShortDateString();
                this.tbObs.Text = PatrimonioSelecionado.Obs;
                this.ckbAtivo.Checked = PatrimonioSelecionado.Ativo;
            }
        }
    }
}

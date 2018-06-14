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

        public Setor SetorSelecionado { get; set; }

        public ManterSetor()
        {
            InitializeComponent();
        }

        private void btCancelarSetor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarSetor_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();

            setor.Nome = tbNomeSetor.Text;
            setor.Gestor = tbNomeGestor.Text;

            Validacao validacao;

            if (SetorSelecionado != null)
            {
                validacao = Program.Gerenciador.CadastrarSetor(setor);
            }
            else
            {
                validacao = Program.Gerenciador.CadastrarSetor(setor);
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
                MessageBox.Show("Setor cadastrado com sucesso!");

            }
            this.Close();
        }
    }
}

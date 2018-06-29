using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patronum.Negocio.Persistencia;

namespace Patronum.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Validacao RemoverPatrimonio(Patrimonio patrimonio)
        {
            Validacao validacao = new Validacao();
            banco.Patrimonios.Remove(patrimonio);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao RemoverSetor(Setor setor)
        {
            Validacao validacao = new Validacao();
            banco.Setores.Remove(setor);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao RemoverFornecedor(Fornecedor fornecedor)
        {
            Validacao validacao = new Validacao();
            banco.Fornecedores.Remove(fornecedor);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarFornecedor(Fornecedor fornecedorAlterado)
        {
            Validacao validacao = new Validacao();
            Fornecedor fornecedorBanco = BuscaFornecedorPorId(fornecedorAlterado.FornecedorId);
            fornecedorBanco.NomeFornecedor = fornecedorAlterado.NomeFornecedor;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarCliente(Cliente clienteAlterado)
        {
            Validacao validacao = new Validacao();
            Cliente clienteBanco = BuscaClientePorId(clienteAlterado.ClienteId);
            clienteBanco.NomeCliente = clienteAlterado.NomeCliente;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarSetor(Setor setorAlterado)
        {
            Validacao validacao = new Validacao();
            Setor setorBanco = BuscaSetorPorId(setorAlterado.SetorId);
            setorBanco.NomeSetor = setorAlterado.NomeSetor;
            setorBanco.NomeGestor = setorAlterado.NomeGestor;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarPatrimonio(Patrimonio patrimonioAlterado)
        {
            Validacao validacao = new Validacao();
            Patrimonio patrimonioBanco = BuscaPatrimonioPorId(patrimonioAlterado.Id);
            patrimonioBanco.Nome = patrimonioAlterado.Nome;
            patrimonioBanco.Setor = patrimonioAlterado.Setor;
            patrimonioBanco.Gestor = patrimonioAlterado.Gestor;
            patrimonioBanco.Fornecedor = patrimonioAlterado.Fornecedor;
            patrimonioBanco.DataAquisi = Convert.ToDateTime(patrimonioAlterado.DataAquisi);
            patrimonioBanco.PrazoGarant = Convert.ToDateTime(patrimonioAlterado.PrazoGarant);
            patrimonioBanco.Nfe = patrimonioAlterado.Nfe;
            patrimonioBanco.ServiceTag = patrimonioAlterado.ServiceTag;
            patrimonioBanco.Obs = patrimonioAlterado.Obs;
            patrimonioBanco.Ativo = patrimonioAlterado.Ativo;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao CadastrarFornecedor(Fornecedor fornecedorAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Setores.Where(c => c.NomeSetor == fornecedorAdicionado.NomeFornecedor).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Nome do Fornecedor", "Já existe um Fornecedor com esse Nome");
            }
            if (validacao.Valido)
            {
                this.banco.Fornecedores.Add(fornecedorAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao CadastrarSetor(Setor setorAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Setores.Where(c => c.NomeSetor == setorAdicionado.NomeSetor).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Nome do Setor", "Já existe um Setor com esse Nome");
            }
            if(this.banco.Setores.Where(c => c.NomeGestor == setorAdicionado.NomeGestor).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Nome do Gestor", "Já existe um Gestor com esse Nome");
            }
            if (validacao.Valido)
            {
                this.banco.Setores.Add(setorAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao CadastrarPatrimonio(Patrimonio patrimonioAdicionado)
        {
            Validacao validacao = new Validacao();
            if (String.IsNullOrEmpty(patrimonioAdicionado.Nfe))
            {
                validacao.Mensagens.Add("Nome", "O campo Nome não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Nfe))
            {
                validacao.Mensagens.Add("Nfe", "O campo Nfe não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.ServiceTag))
            {
                validacao.Mensagens.Add("ServiceTag", "O campo ServiceTag não pode ser nulo");
            }
            if (validacao.Valido)
            {
                this.banco.Patrimonios.Add(patrimonioAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao CadastrarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Clientes.Where(c => c.NomeCliente == clienteAdicionado.NomeCliente).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Nome do Cliente", "Já existe um Cliente com esse Nome");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.NomeCliente))
            {
                validacao.Mensagens.Add("Nome do Cliente", "O campo Nome do Cliente não pode ser nulo");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.SetorCliente))
            {
                validacao.Mensagens.Add("Nome do Setor", "O campo Nome do Setor não pode ser nulo");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.CNPJ))
            {
                validacao.Mensagens.Add("CNPJ", "O campo CNPJ não pode ser nulo");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O campo Email não pode ser nulo");
            }
            if (!clienteAdicionado.Email.Contains("@") && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Email", "Email no formato inválido");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.Endereco))
            {
                validacao.Mensagens.Add("Endereço", "O campo Endereço não pode ser nulo");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.Telefone))
            {
                validacao.Mensagens.Add("Telefone", "O campo Telefone não pode ser nulo");
            }
            if (String.IsNullOrEmpty(clienteAdicionado.Resp))
            {
                validacao.Mensagens.Add("Resp", "O campo Resp não pode ser nulo");
            }
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Cliente BuscaClientePorId(long id)
        {
            return this.banco.Clientes.Where(c => c.ClienteId == id).FirstOrDefault();
        }

        public Patrimonio BuscaPatrimonioPorId(long id)
        {
            return this.banco.Patrimonios.Where(c => c.Id == id).FirstOrDefault();
        }

        public Setor BuscaSetorPorId(long id)
        {
            return this.banco.Setores.Where(c => c.SetorId == id).FirstOrDefault();
        }

        public Fornecedor BuscaFornecedorPorId(long id)
        {
            return this.banco.Fornecedores.Where(c => c.FornecedorId == id).FirstOrDefault();
        }

         public List<Patrimonio> TodosOsPatrimonios()
        {
            return this.banco.Patrimonios.ToList();
        }

        public List<Setor> TodosOsSetores()
        {
            return this.banco.Setores.ToList();
        }

        public List<Fornecedor> TodosOsFornecedores()
        {
            return this.banco.Fornecedores.ToList();
        }
        public List<Cliente> TodosOsClientes()
        {
            return this.banco.Clientes.ToList();
        }
    }
}

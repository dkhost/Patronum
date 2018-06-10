using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio
{
    public class Gerenciador
    {
        private List<Patrimonio> Patrimonios;

        public Gerenciador()
        {
            this.Patrimonios = new List<Patrimonio>();
        }

        public Validacao CadastrarPatrimonio (Patrimonio patrimonioAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.Patrimonios.Where(c=> c.Id == patrimonioAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um patrimônio com esse código");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O campo Nome não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Setor))
            {
                validacao.Mensagens.Add("Setor", "O campo Setor não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Gestor))
            {
                validacao.Mensagens.Add("Gestor", "O campo Gestor não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Fornecedor))
            {
                validacao.Mensagens.Add("Fornecedor", "O campo Fornecedor não pode ser nulo");
            }
            if (String.IsNullOrEmpty(patrimonioAdicionado.Servicetag))
            {
                validacao.Mensagens.Add("ServiceTag", "O campo ServiceTag não pode ser nulo");
            }

            if(validacao.Valido)
            {
                this.Patrimonios.Add(patrimonioAdicionado);
            }
            return validacao;

        }

         public List<Patrimonio> TodosOsPatrimonios()
        {
            return this.Patrimonios.ToList();
        }
    }
}

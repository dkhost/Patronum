﻿using Patronum.Negocio.Models;
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

        public Validacao RemoverPatrimonio (Patrimonio patrimonio )
        {
            Validacao validacao = new Validacao();
            banco.Patrimonios.Remove(patrimonio);
            banco.SaveChanges();
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
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao CadastrarPatrimonio (Patrimonio patrimonioAdicionado)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Patrimonios.Where(c=> c.Id == patrimonioAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um patrimônio com esse Código");
            }
            if (this.banco.Patrimonios.Where(c => c.Id == patrimonioAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("ServiceTag", "Já existe um patrimônio com essa ServiceTag");
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
            if(String.IsNullOrEmpty(patrimonioAdicionado.Nfe))
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

        public Patrimonio BuscaPatrimonioPorId(long id)
        {
            return this.banco.Patrimonios.Where(c => c.Id == id).FirstOrDefault();
        }

         public List<Patrimonio> TodosOsPatrimonios()
        {
            return this.banco.Patrimonios.ToList();
        }
    }
}

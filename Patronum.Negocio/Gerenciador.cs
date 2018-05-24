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
        private List<Setor> Setores;

        public Gerenciador()
        {
            this.Patrimonios = new List<Patrimonio>();
            this.Setores = new List<Setor>();
        }

        public void CadastrarPatrimonio (Patrimonio patrimonioAdicionado)
        {

            if (String.IsNullOrEmpty(patrimonioAdicionado.Nome))
            {
                return;
            }

            this.Patrimonios.Add(patrimonioAdicionado);
        }

         public List<Patrimonio> TodosOsPatrimonios()
        {
            return this.Patrimonios.ToList();
        }

        public List<Setor> TodosOsSetores()
        {
            return this.Setores.ToList();
        }

        public void CadastrarSetor (Setor setorAdicionado)
        {
            if (String.IsNullOrEmpty(setorAdicionado.Nome))
            {
                return;
            }
        }
    }
}

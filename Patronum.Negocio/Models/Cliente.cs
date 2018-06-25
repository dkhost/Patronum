using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio.Models
{
    [Table(name: "Clientes")]
    public class Cliente
    {
        public long ClienteId { get; set; }
        public String CNPJ { get; set; }
        public String NomeCliente { get; set; }
        public String SetorCliente { get; set; }
        public String Resp { get; set; }
        public String Endereco { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }

        [NotMapped]
        public String DescricaoEmpresa
        {
            get
            {
                return this.NomeCliente + " - " + this.CNPJ;
            }
        }

        [NotMapped]
        public String DescricaoSetorEmpresa
        {
            get
            {
                return this.SetorCliente;
            }
        }

        [NotMapped]
        public String DescricaoResp
        {
            get
            {
                return this.Resp;
            }
        }
    }
}

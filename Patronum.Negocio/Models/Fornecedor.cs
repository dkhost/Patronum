using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio.Models
{
    [Table(name: "Fornecedores")]
    public class Fornecedor
    {
        public long FornecedorId { get; set; }
        public String NomeFornecedor { get; set; }

        [NotMapped]
        public String DescricaoFornecedor
        {
            get
            {
                return this.NomeFornecedor;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio.Models
{
    [Table(name: "Setores")]
    public class Setor
    {

        public long SetorId { get; set; }
        public String NomeSetor { get; set; }
        public String NomeGestor { get; set; }

        [NotMapped]
        public String DescricaoSetor
        {
            get
            {
                return this.NomeSetor;
            }
        }

        [NotMapped]
        public String DescricaoGestor
        {
            get
            {
                return this.NomeGestor;
            }
        }

    }
}

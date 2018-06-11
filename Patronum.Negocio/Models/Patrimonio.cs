using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Negocio.Models
{
    public class Patrimonio
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public String Setor { get; set; }
        public String Gestor { get; set; }
        public String Fornecedor { get; set; }
        public DateTime DataAquisi { get; set; }
        public DateTime PrazoGarant { get; set; }
        public long Nfe { get; set; }
        public String ServiceTag { get; set; }

        public String Descrever()
        {
            return String.Format($"{this.Id} - {this.Nome} - {this.Setor} - {this.Gestor} - {this.Fornecedor} - {this.DataAquisi} - {this.PrazoGarant} - {this.Nfe} - {this.ServiceTag}");
        }
    }
}

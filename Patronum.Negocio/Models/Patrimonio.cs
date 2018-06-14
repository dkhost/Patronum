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
        public DateTime DataAquisi { get; set; }
        public DateTime PrazoGarant { get; set; }
        public String Nfe { get; set; }
        public String ServiceTag { get; set; }
        public String Obs { get; set; }
    }
}

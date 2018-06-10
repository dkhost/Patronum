using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Patronum.Negocio.Persistencia
{
    public class Banco
    {
        private String NomeArquivo = "banco.xml";
        public List<Patrimonio> Patrimonios;

        public Banco()
        {
            this.Patrimonios = new List<Patrimonio>();

            this.CarregarDados();
        }

        public void SalvarDados()
        {
            Dados dados = new Dados();
            dados.Patrimonios = this.Patrimonios;
            StreamWriter arquivo = new StreamWriter(this.NomeArquivo);
            XmlSerializer serializer = new XmlSerializer(typeof(Dados));
            serializer.Serialize(arquivo, dados);
            arquivo.Close();
        }

        public void CarregarDados()
        {
            if(File.Exists(NomeArquivo))
            {
                FileStream arquivo = File.OpenRead(NomeArquivo);
                XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                Dados dados = serializer.Deserialize(arquivo) as Dados;
                this.Patrimonios = dados.Patrimonios;
            }
        }
    }
}

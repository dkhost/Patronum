using Patronum.Negocio;
using Patronum.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patronum.Telas
{

    class Program
    {
        static Gerenciador gerenciador = new Gerenciador();

        static void Main(string[] args)
        {

            int opcao = 0;
            do
            {
                Console.WriteLine("========== Patronum Gestão Patrimonial ==========");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar patrimonio");
                Console.WriteLine("2 - Listar patrimonios");
                Console.WriteLine("3 - Cadastrar setor");
                Console.WriteLine();
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1: CadastrarPatrimonio();
                        break;
                    case 2: ListarPatrimonio();
                        break;
                    default: Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }

        public static void CadastrarPatrimonio()
        {
            Console.Clear();
            Patrimonio novoPatrimonio = new Patrimonio();
            Console.Write("Digite o código do Patrimônio: ");
            novoPatrimonio.Id = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite o nome do Patrimônio: ");
            novoPatrimonio.Nome = Console.ReadLine();
            Console.Write("Digite o nome do Fornecedor deste produto: ");
            novoPatrimonio.Fornecedor = Console.ReadLine();
            Console.Write("Digite o código da Nota Fiscal: ");
            novoPatrimonio.Nfe = Convert.ToInt64(Console.ReadLine());
            Console.Write("Digite o nome do Setor/Local deste produto: ");
            novoPatrimonio.Setor = Console.ReadLine();
            Console.Write("Digite o nome do Gestor/Responsável por este patrimônio: ");
            novoPatrimonio.Gestor = Console.ReadLine();
            Console.Write("Digite a Data de Aquisição:");
            novoPatrimonio.DataAquisi = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o Prazo da Garantia: ");
            novoPatrimonio.PrazGarant = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite a service tag do proturo: ");
            novoPatrimonio.Servicetag = Convert.ToInt64(Console.ReadLine());

            gerenciador.CadastrarPatrimonio(novoPatrimonio);
            Console.WriteLine("Patrimônio cadastrado com sucesso!");
            Console.ReadLine();
        }

        public static void ListarPatrimonio()
        {
            List<Patrimonio> patrimoniosCadastrados = gerenciador.TodosOsPatrimonios();
            foreach (Patrimonio patrimonio in patrimoniosCadastrados)
            {
                Console.WriteLine(patrimonio.Descrever());
            }
        }
    }
}

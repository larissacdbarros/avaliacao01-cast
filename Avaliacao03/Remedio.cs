using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao03
{
    public class Remedio
    {
        private string Nome { get; set; }
        private int Codigo { get; set; }

       //public List<Remedio> remedios = RemedioRepository.InicializaRemedios();
       public List<Remedio> remedios = new List<Remedio>();

        public Remedio() { }

        public Remedio(string nome, int codigo) {
            this.Nome = nome;
            this.Codigo = codigo;
        }

        public void Cadastrar()
        {
            Console.Clear();
            Console.Write("Informe o nome do medicamento:");

            string nome = Console.ReadLine().Trim().ToLower();
            Console.Write("Informe o código do medicamento:");
            int codigo = int.Parse(Console.ReadLine().Trim().ToLower());

            remedios.Add(new Remedio(nome, codigo));
            Console.WriteLine("Tecle ENTER para confirmar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }

        public void Listar()
        {
            Console.Clear();

            //List<Remedio>  remediosOrdenados = remedios.OrderBy<co>

            foreach (Remedio remedio in remedios)
            {
                Console.WriteLine($"Nome: {remedio.Nome}    Código:{remedio.Codigo}");
            }
            Console.WriteLine("\nQuantidade total de medicamentos cadastrados: " + remedios.Count());

            Console.WriteLine("Tecle ENTER para confirmar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }




        public void Remover()

        {
            Console.Clear();

            Listar();

            foreach (Remedio remedio in remedios)
            {
                Console.Write("Informe o nome do medicamento que deseja remover: ");
                string nome = Console.ReadLine().Trim().ToLower() ;
                if (nome.Equals(remedio.Nome))
                {

                    remedios.Remove(remedio);
                    break;
                }
            }

            Console.WriteLine("Tecle ENTER para confirmar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }

        public void Buscar()
        {
            Console.Clear();

            Console.Write("Informe o nome do medicamento está buscando: ");
            string nome = Console.ReadLine().Trim().ToLower();
            foreach (Remedio remedio in remedios)
            {
                if (nome.Equals(remedio.Nome))
                {
                    Console.WriteLine("Remédio encontrado");
                    Console.WriteLine($"Nome: {remedio.Nome}    Código:{remedio.Codigo}");
                    break;
                }
                else if (nome.Equals(remedio.Nome.Substring(3)))
                {
                    Console.WriteLine("Remédio encontrado");
                }
                else
                {
                    Console.WriteLine("Remédio não encontrado");
                };


            }
            Console.WriteLine("Tecle ENTER para confirmar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }

    }
   
     
}



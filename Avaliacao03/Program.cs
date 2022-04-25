using System;

namespace Avaliacao03
{
    internal class Program
    {
        /*
         
            Objetivo: Criar uma coleção (array ou list) com nomes de remédios e efetuar uma busca para saber se existe o 
            mesmo no estoque, indicar a posição do mesmo no array.
            Plus
            
           
            3.	Se o programa ordenar os elementos //
            4.	Se o programa conseguir buscar pela parte final do nome do remédio
            
         */
        static void Main(string[] args)
        {
            Remedio remedios = new Remedio();

            bool sistema = true;

            while (sistema)
            {
                switch (Menu())
                {
                    case 1:
                        remedios.Cadastrar();
                        break;
                    case 2:
                        remedios.Listar();
                        break;
                    case 3:
                        remedios.Remover();
                        break;
                    case 4:
                        remedios.Buscar();
                        break;
                    case 5:
                        Console.WriteLine("Sistema encerrado");
                        sistema = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }


        }
        public static int Menu()
        {
            Console.WriteLine("MENU DE OPÇÕES \n------------------------ " +
                "\n|1 - CADASTRAR REMÉDIO " +
                "\n|2 - LISTAR TODOS OS REMÉDIOS" +
                "\n|3 - REMOVER REMÉDIO" +
                "\n|4 - BUSCAR REMÉDIO" +
                "\n|5 - SAIR " +
                "\n------------------------ " +
                "\n ESCOLHA SUA OPÇÃO");

            int opcaoSelecionada = int.Parse(Console.ReadLine().Trim());
            return opcaoSelecionada;
        }
    }
}

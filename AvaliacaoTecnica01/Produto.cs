using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    public class Produto
    {
        private string Nome { get; set; }
        private int Codigo { get; set; }
        private double Preco { get; set; }
        private uint Quantidade { get; set; }

        Produto[] produtos { get; set; }

        public Produto()
        {

        }
        public Produto(string nome, int codigo, double preco, uint quantidade)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public Produto[] CadastroProduto()
        {
            Console.WriteLine("-------------CADASTRO DE PRODUTOS-------------");
            Console.WriteLine("Informe a quantidade de produtos que deseja cadastrar no estoque: ");
            int qtdProdutosCadastrados = int.Parse(Console.ReadLine());
            produtos = new Produto[qtdProdutosCadastrados];

            for (int i = 0; i < qtdProdutosCadastrados; i++)
            {

                int id = i + 1;
                Console.WriteLine($"\nPRODUTO {id}");

                Console.WriteLine($"Informe o nome do produto {id}:");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine($"Informe o preço do produto {id}:");
                double preco = double.Parse(Console.ReadLine());

                Console.WriteLine($"Informe a quantidade deste produto armazenado em estoque:");
                uint qtdestoque = uint.Parse(Console.ReadLine());

                produtos[i] = new Produto(nomeProduto, id, preco, qtdestoque);

            }

            return produtos;
        }

        public void ListarProdutos()
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Codigo}\tNome: {produto.Nome} \tPreço: {produto.Preco} \tQuantidade em estoque: {produto.Quantidade} ");
            }
        }

        public void Venda(Funcionario funcionario)
        {
            //Funcionario funcionario = new Funcionario();

            bool sistema = true;
            while (sistema)
            {
                ListarProdutos();
                Console.WriteLine("\n\n-------------VENDA-------------");
                Console.WriteLine("Informe o código do produto que o cliente deseja comprar:");
                int codigoProduto = int.Parse(Console.ReadLine());
                foreach (Produto produto in produtos)
                {
                    if (produto.Codigo == codigoProduto)
                    {
                        Console.WriteLine($"A quantidade de {produto.Nome} disponívei é: {produto.Quantidade}");
                        Console.WriteLine("\nInforme a quantidade desejada: ");
                        uint qtdProduto = uint.Parse(Console.ReadLine());
                       
                        if (qtdProduto <= produto.Quantidade)
                        {

                            produto.Quantidade = produto.Quantidade - qtdProduto; //quantidade de produtos no estoque
                            funcionario.CalculadoraVendas(qtdProduto); //quantidade de produtos que está sendo vendida
                           
                            funcionario.CalculadoraValorVendas(produto.Preco * qtdProduto);
                            Console.WriteLine("Venda Realizada!");
                            Console.WriteLine($"A quantidade de {produto.Nome} agora é: {produto.Quantidade}");

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade indisponível. Informe uma quantidade válida.");
                            
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Código inválido, informar um código válido para realizar a compra");
                    }
                    break;

                }
                break;
                                
            }
        }


    }
}


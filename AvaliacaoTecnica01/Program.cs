using System;


namespace Avaliacao01
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* VENDAS E COMIÇÕES 
             - Sistema que informa total de vendas e a comissão dos funcinários
                 > Pedir quantidade de índices do arraya ao usuário e criar o array ok
                 > Da mesma forma com o array Produtos (fazer abstração da classe) OK
             - Cada venda deve ter :
                 > Id do vendedor 
                 > Cada ato de venda efetua a venda de apenas 1 produto
                 > Vendas do vendedor armazenadas em array ou list, para saber o total de vendas e a comissão
                     Obs.: O total de vendas que pode ser feita depende diretamente da quantidade 
                             total de produtos que temos cadastrados no array produtos

             - A o efetuar a venda o sistema deve poder verificar se existe quantidade suficiente do produto 
               para efetuar as vendas e as atualizações de estoque de cada produto.


             PLUS
             >> Se o sistema conseguir informar no momento da venda ao vendedor, as quantidades atuais do 
             produto e a quantidade mínima e máxima para alguém responsável quando estes limites forem atingidos


            >>>>>>>>>> PROBLEMAS <<<<<<<<<<<<<<
            
            NÃO ESTA ARMAZEENADO AS INFORMAÇOES QUANDO SALVA


              */
            
            Produto produto = new Produto();
            
            Funcionario funcionario = AcessoFuncionarios();

            bool sistema = true;
            while (sistema)
            {
                switch (Menu())
                {
                    case 1:
                        Console.Clear();
                        produto.CadastroProduto();
                        break;
                    case 2:
                        Console.Clear();
                        produto.ListarProdutos();
                        break;
                    case 3:
                        Console.Clear();
                        produto.Venda(funcionario);
                        break;
                    case 4:
                        Console.Clear();
                        CalculoComissao(funcionario);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Sistema finalizado");
                        sistema = false;
                        break;

                }
            }
            
        }

        public static Funcionario AcessoFuncionarios()
        {
            Funcionario[] allFuncionarios = FuncionarioRepository.FuncionariosCadastrados();
            
            while (true)
            {
                Console.Write("Vendedor informe seu ID para acessar o sistema:");
                int id = int.Parse(Console.ReadLine());

                foreach (Funcionario funcionario in allFuncionarios)
                {
                    if (funcionario.Id == id)
                    {
                       Console.WriteLine("Acesso liberado");
                       return funcionario;
                        
                    }
                    else
                    {
                        Console.WriteLine("Acesso negado! Informe um ID válido");
                        break;
                    }

                }

            }

        }

        public static int Menu()
        {
            Console.WriteLine("BEM VINDO AO SISTEMA");
            Console.WriteLine("\n \n MENU DE OPÇÕES \n------------------------ " +
                "\n|1 - CADASTRAR PRODUTOS " +
                "\n|2 - LISTAR PRODUTOS " +
                "\n|3 - REALIZAR VENDA" +
                "\n|4 - CALCULAR COMISSÃO" +
                "\n|5 - SAIR " +
                "\n------------------------ " +
                "\n ESCOLHA SUA OPÇÃO");

            int opcaoSelecionada = int.Parse(Console.ReadLine().Trim());
            return opcaoSelecionada;
        }

        public static void CalculoComissao(Funcionario funcionario)
        {

            Console.Write($"O valor da comissão do vendedor é :");
            if (funcionario.QtdProdutosVendidos >= 0 && funcionario.QtdProdutosVendidos <= 5)
            {
                funcionario.Comissao = funcionario.ValorVendas * 0.004;
                Console.WriteLine(funcionario.Comissao);
            }
            else if (funcionario.QtdProdutosVendidos >= 6 && funcionario.QtdProdutosVendidos <= 10)
            {
                funcionario.Comissao = funcionario.ValorVendas * 0.013;
                Console.WriteLine(funcionario.Comissao);
            }
            else if (funcionario.QtdProdutosVendidos >= 11 && funcionario.QtdProdutosVendidos <= 15)
            {
                funcionario.Comissao = funcionario.ValorVendas * 0.03;
                Console.WriteLine(funcionario.Comissao);
            }
            else
            {
                funcionario.Comissao = funcionario.ValorVendas * 0.05;
                Console.WriteLine(funcionario.Comissao);
            }

        }

    }
}


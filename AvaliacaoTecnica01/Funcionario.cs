using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    public class Funcionario
    {
        private string Nome { get; set; }   
        private int Id { get; set; }

        private double ValorVendas { get; set; } 
        
        private uint QtdProdutosVendidos { get; set; }

        private double Comissao { get; set; }   

        public Funcionario()
        {
           
        }
        public Funcionario(string nome, int id)
        {
            this.Nome = nome;   
            this.Id = id;
        }
        
        
        public void AcessoFuncionarios()
        {
            Funcionario[] allFuncionarios = FuncionarioRepository.FuncionariosCadastrados();
            bool acesso = true;

            while (acesso)
            {
                Console.Write("Vendedor informe seu ID para acessar o sistema:");
                int id = int.Parse(Console.ReadLine());
                
                foreach (Funcionario funcionario in allFuncionarios)
                {
                    if (funcionario.Id == id)
                    {
                        Console.WriteLine("Acesso liberado");
                        acesso = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Acesso negado! Informe um ID válido");
                        break;
                    }
                                     
                }
                
            }
           
        }

        public void CalculoComissao()
        {
            Funcionario f = new Funcionario();

            Console.Write($"O valor da comissão do vendedor é :");
            if(QtdProdutosVendidos >= 0 && QtdProdutosVendidos<= 5)
            {
                this.Comissao = ValorVendas * 0.004;
                Console.WriteLine(this.Comissao);
            }else if (QtdProdutosVendidos >= 6 && QtdProdutosVendidos <= 10)
            {
                this.Comissao = ValorVendas * 0.013;
                Console.WriteLine(this.Comissao);
            }
            else if (QtdProdutosVendidos >= 11 && QtdProdutosVendidos <= 15)
            {
                this.Comissao = ValorVendas * 0.03;
                Console.WriteLine(this.Comissao);
            }
            else
            {
                this.Comissao = ValorVendas * 0.05;
                Console.WriteLine(this.Comissao);
                }

        }

        public void CalculadoraVendas(uint qtdProdutosVendidos)
        {
            this.QtdProdutosVendidos += qtdProdutosVendidos;
        }

        public void CalculadoraValorVendas(double valor)
        {
            this.ValorVendas += valor;
        }
        
    }

    public class FuncionarioRepository
    {
        public static Funcionario[] FuncionariosCadastrados()
        {
            return new Funcionario[] {
                new Funcionario("Larissa Duarte", 123),
                new Funcionario("Rodrigo Maia", 456),
                new Funcionario("Paulo Gustavo", 789),
            };
        }
    }
    
}

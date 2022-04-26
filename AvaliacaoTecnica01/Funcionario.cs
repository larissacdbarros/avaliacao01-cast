using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao01
{
    public class Funcionario
    {
        public string Nome { get; set; }   
        public int Id { get; set; }
        
        public double ValorVendas { get; set; } 
        
        public uint QtdProdutosVendidos { get; set; }
       
        public double Comissao { get; set; }   

        public Funcionario()
        {
           
        }
        public Funcionario(string nome, int id)
        {
            this.Nome = nome;   
            this.Id = id;
        }
        

        

        public void CalculadoraVendas(uint qtdProdutosVendidos)
        {
            Console.WriteLine($"cal vendas antes : qtd produ vendidos{this.QtdProdutosVendidos}");
            this.QtdProdutosVendidos += qtdProdutosVendidos;
            Console.WriteLine($"cal vendas depois; qtd produ vendidos{this.QtdProdutosVendidos}");

        }

        public void CalculadoraValorVendas(double valor)
        {
            Console.WriteLine($"cal VALOR vendas antes : valor vendido{this.ValorVendas}");
            this.ValorVendas += valor;
            Console.WriteLine($"cal VALOR vendas antes : valor vendido{this.ValorVendas}");

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

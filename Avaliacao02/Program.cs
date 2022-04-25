using System;

namespace Avaliacao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Objetivo: Um jogo de adivinhação (números) que consiga informar ao usuário em quantas jogadas ele conseguiu acertar 
            o número pensado pelo sistema. As dificuldades extras como, quantidade de jogadas, ou definir o limite de números 
            mínimo e máximo podem ser definidas.

            1.	Se a cada resposta errada o sistema informar uma resposta diferenciada do tipo: errou tente de novo, xiii passou longe, 
            tá frio muito frio, etc... ponto extra
            2.	SE o sistema continuar a funcionar em um loop até que alguma ação final seja alcançada: número de tentativas, 
            acerto do jogador, ao final de cada tentativa perguntar se ele deseja continuar.
            3.	Se no final forem passadas informações diversas: número de tentativas, quantas vezes ele se aproximou 
            ao número sorteado faltando um para mais ou para menos.

             */

            bool continuar = true;
            int numTentativas = 0;

            Console.WriteLine("------------JOGO DA ADVINHAÇÃO------------");

            while (continuar)
            {
                int numeroComputador = new Random().Next(1, 5);

                Console.WriteLine("Tente descobrir o número sorteado pelo computador entre 1 e 10\n");
                int numUsuario = int.Parse(Console.ReadLine());

                numTentativas++;

                if (numeroComputador == numUsuario)
                {
                    Console.Clear();
                    Console.WriteLine("\tO número sorteado pelo computador foi: " + numeroComputador + "\n");

                    

                    if(numTentativas <= 3)
                    {
                        Console.WriteLine($"\tParabéns você acertou com apenas {numTentativas} tentativas");
                    }
                    else
                    {
                        Console.WriteLine($"\tParabéns você acertou, mas demorou demais... precisou de {numTentativas} tentativas");
                    }
                    break;
                }
                else if (numUsuario >= 1 && numUsuario <= 10)
                {
                    Console.Clear();
                    if(numUsuario == numeroComputador + 2 || numUsuario == numeroComputador - 2)
                    {
                        Console.WriteLine($"\tEITA PASSOU PERTO! \n O número sorteado pelo computador foi o {numeroComputador}. Tente novamente!\n");
                    }
                    else
                    {
                        {
                            Console.WriteLine($"\tPASSOU LONGE!!! \n O número sorteado pelo computador foi o {numeroComputador}. Tente novamente!\n");

                        }
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"O número {numUsuario} não está dentro da faixa estipulada. \n Insira um número válido\n");

                }

            }

        }
    }
}

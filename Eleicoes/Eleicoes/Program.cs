using System;

namespace Eleicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalDeEleitores = 0, votosValidos = 0, votosBrancos = 0, votosNulos = 0;


            do
            {

                Console.WriteLine("Digite o total de eleitores da Seção: ");
                totalDeEleitores = Convert.ToDouble(Console.ReadLine());
                if (totalDeEleitores == 0)
                {
                    Console.WriteLine("Programa encerrado com sucesso");
                    break;
                }
                Console.WriteLine("Digite o total de votos válidos da Seção: ");
                votosValidos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o total de votos brancos da Seção: ");
                votosBrancos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o total de votos nulos da Seção: ");
                votosNulos = Convert.ToDouble(Console.ReadLine());

                double percentualVotosValidos = (votosValidos / totalDeEleitores) * 100;
                Console.WriteLine("O percentual de votos válidos foi de: " + Math.Round(percentualVotosValidos, 2) + "%");

                double percentualVotosBrancos = (votosBrancos / totalDeEleitores) * 100;
                Console.WriteLine("O percentual de votos brancos foi de: " + Math.Round(percentualVotosBrancos, 2) + "%");

                double percentualVotosNulos = (votosNulos / totalDeEleitores) * 100;
                Console.WriteLine("O percentual de votos nulos foi de: " + Math.Round(percentualVotosNulos, 2) + "%");

              
            } while (totalDeEleitores != 0);
        }
    }
}

using System.Security.Cryptography;

namespace JogoDeDados.ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

        const int limiteLinhaChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;
            bool jogoEstaEmAndamento = true;

            while (jogoEstaEmAndamento)
            {
                Console.Clear();

                Console.WriteLine("=============================");
                Console.WriteLine("Jogo De Dados");
                Console.WriteLine("=============================");

                Console.Write("Pressione ENTER para lançar um dado");
                Console.ReadLine();

                int resultado = RandomNumberGenerator.GetInt32(1, 7);

                Console.WriteLine("=============================");
                Console.WriteLine($"O dado rolou para o número {resultado}");
                Console.WriteLine("=============================");

                posicaoJogador += resultado;

                Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}");

                if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
                {
                    Console.WriteLine($"\nEVENTO: Avanço de {bonusAvancoExtra} casas!");
                    posicaoJogador += bonusAvancoExtra;

                    Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}");
                }

                else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                {
                    Console.WriteLine($"\nRecuo de {penalidadeRecuo} casas");
                    posicaoJogador -= penalidadeRecuo;

                    Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}");
                }

                if (posicaoJogador >= limiteLinhaChegada)
                {
                    Console.WriteLine("\nParabéns! Você alcançou a linha de chegada.");

                    jogoEstaEmAndamento = false;

                    Console.Write("\nPressione ENTER para continuar...");
                    Console.ReadLine();

                    continue;
                }

                Console.Write("\nPressione ENTER para continuar...");
                Console.ReadLine();


                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("Rodada do Computador");
                Console.WriteLine("===========================================");

                int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

                Console.WriteLine($"O número sorteado foi: {resultadoComputador}");
                Console.WriteLine("==============================================");

                posicaoComputador += resultadoComputador;

                Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");

                if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                {
                    Console.WriteLine($"\nAvanço de {bonusAvancoExtra} casas!");
                    posicaoComputador += bonusAvancoExtra;

                    Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");
                }

                else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                {
                    Console.WriteLine($"\nRecuo de {penalidadeRecuo} casas");
                    posicaoComputador -= penalidadeRecuo;

                    Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");
                }

                if (posicaoComputador >= limiteLinhaChegada)
                {
                    Console.WriteLine("\nO computador alcançou a linha de chegada.");

                    jogoEstaEmAndamento = false;
                }

                Console.Write("\nPressione ENTER para continuar");
                Console.ReadLine();
            }
            while (true)
            {
                Console.Write("Deseja continuar? s/N");
                string? opcaoContinuar = Console.ReadLine()?.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
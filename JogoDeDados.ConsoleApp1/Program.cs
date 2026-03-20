using System.Security.Cryptography;

namespace JogoDeDados.ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        const int limitedechegada = 30;
        bool JogoemAndamento = true;

        while (JogoemAndamento) //Loop do jogo
        {
            int posicaoJogador = 0;

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

            if (posicaoJogador < limitedechegada)
            {
                Console.Write($"O Jogador está na posição: {posicaoJogador} de {limitedechegada}");
            }
        }


        while (true) //Loop principal
        {
            Console.Write("Deseja continuar? s/N");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }

    }
}
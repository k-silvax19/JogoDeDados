namespace JogoDosDados.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            InicializarPartida();

            while (true)
            {
                Jogador.ExecutarRodadada();

                if (Jogador.Venceu())
                    break;

                Computador.ExecutarRodadada();

                if (Computador.Venceu())
                    break;
            }

            if (!JogadorDesejaContinuar())
                break;
        }
    }

    static void InicializarPartida()
    {
        Jogador.posicao = 0;
        Computador.posicao = 0;
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("\nDeseja continuar? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        return true;
    }
}
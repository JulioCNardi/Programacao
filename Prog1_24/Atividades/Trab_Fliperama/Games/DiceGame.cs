using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trab_Fliperama.Games
{
    public class DiceGame
    {
        public DiceGame()
        {
            this.Init();
        }

        public void Init() 
        {
            int playerPoints = 0;
            int rivalPoints = 0;

            Console.WriteLine("Dado");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Nesse jogo você e o computador disputarão uma partida de 5 rounds");
            Console.WriteLine("Cada rodada é ganha se obtendo o maior numero ao rolar os dados");
            Console.WriteLine("Ganha a partida quem tiver ganhado mais rounds.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey(true);

            for (int i = 0; i < 5; i++)
{
            Console.WriteLine($"Round {i + 1}");
            int rivalRandomNum = Random.Shared.Next(1, 7);
            Console.WriteLine("Computador rolou " + rivalRandomNum);

            Console.Write("Pressione qualquer tecla para rolar o dado");
            Console.ReadKey(true);
            Console.WriteLine();
            int playerRandomNum = Random.Shared.Next(1, 7);
            Console.WriteLine("Você rolou um " + playerRandomNum);

            if (playerRandomNum > rivalRandomNum)
            {
                playerPoints++;
                Console.WriteLine("Você venceu o round.");
            }
            else if (playerRandomNum < rivalRandomNum)
            {
                rivalPoints++;
                Console.WriteLine("O computador venceu o round.");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine($"O placar agora é : {playerPoints}. Computador : {rivalPoints}.");
        if (playerPoints > rivalPoints)
        {
            Console.WriteLine("Você venceu :D");
        }
        else if (playerPoints < rivalPoints)
        {
            Console.WriteLine("Você perdeu :(");
        }
        else
        {
            Console.WriteLine("Empate.");
        }
       Console.Write("Pressione qualquer tecla para encerrar o programa");
        Console.ReadKey(true);
        }
    }
}
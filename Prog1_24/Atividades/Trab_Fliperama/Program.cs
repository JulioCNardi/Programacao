using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Views;
using Trab_Fliperama.Games;

bool aux = true;
do{
    Console.WriteLine("***************************");
    Console.WriteLine("REDE DE FLIPERAMAS DIAMANTE");
    Console.WriteLine("***************************");
    Console.WriteLine();

    Console.WriteLine("1 - Administração Jogadores");
    Console.WriteLine("2 - Administração Jogos");
    Console.WriteLine("0 - SAIR");

    int menu = 0;

    try
    {
        menu = Convert.ToInt32(Console.ReadLine());

        switch(menu)
        {
            case 1:
                PlayerView playerView =  new PlayerView();
            break;
            case 2:
                GameView gameView = new GameView();
            break;
            case 0:
                aux = false;
                Console.WriteLine("Adeus!");
            break;

            default:
                Console.WriteLine("Opção inválida.");                         
            break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inválida.");
        menu = -1;
        aux = true;
    }

}while(aux);
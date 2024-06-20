using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Controllers;

namespace Trab_Fliperama.Views
{
    public class PlayerView
    {

    private PlayerController playerController;

        public PlayerView() 
        {
            playerController = new PlayerController();
            this.Init();
        }
        public void Init()
        {
            Console.WriteLine("MENU JOGADOR");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Jogador");
                Console.WriteLine("2 - Pesquisar Jogador");
                Console.WriteLine("3 - Lista todos os Jogadores");
                Console.WriteLine("4 - Editar Jogador");
                Console.WriteLine("5 - Remover Jogador");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                            InsertPlayer();
                        break;
                        case 2:
                            SearchPlayer();
                        break;
                        case 3: 
                            ListPlayers();
                        break;
                        case 4:
                            EditPlayers();
                        break;
                        case 5:
                            RemovePlayers();
                        break;
                        default: 
                            Console.WriteLine("Opção inválida.");
                            aux = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
        }        

        private void InsertPlayer()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("INSERIR NOVO JOGADOR");
            Console.WriteLine("------------------");

            Player player = new Player();
            
            Console.Write("Nome:");
            player.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Quantidade de Tickets possuidos:");
            player.Tickets = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Quantidade de jogos ganhos:");
            player.GamesWon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Quantidade de jogos perdidos:");
            player.GamesLost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            try
            {
                playerController.Insert(player);
                Console.WriteLine("Jogador inserido com sucesso!");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na inserção do jogador");
            }
        }

        private void SearchPlayer()
        {    
            int aux = -1;
            do
            {
                Console.WriteLine("PESQUISAR JOGADOR");
                Console.WriteLine("------------------");
                Console.WriteLine("1 - Buscar por Id");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - Sair");   

                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);
                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Informe o id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        ShowPlayerById(id);
                    break;
                    case 2:
                        Console.WriteLine("Informe o nome:");
                        string name = Console.ReadLine();
                        ShowPlayersByName(name);
                    break;

                    case 0:
                    break;

                    default: 
                        aux = -1;
                        Console.WriteLine("Opção inválida!");
                    break;
                }                         
            } while(aux != 0);            
        }

        private void ShowPlayerById(int id)
        {            
            Player? p = playerController.Get(id);

            if(p != null)
            {
                Console.WriteLine(p.ToString());
            }
            else
            {
                Console.WriteLine($"Consumidor de id {id} não encontrado!");
            }
        }

        private void ShowPlayersByName(string name)
        {
            List<Player> result = playerController.GetByName(name);

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado.");
                return;                
            }

            foreach(Player player in result)
            {
                Console.WriteLine(player.ToString());
            }
        }

        private void ListPlayers()
        {
            List<Player> result = playerController.Get();

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado.");
                return;                
            }

            foreach(Player player in result)
            {
                Console.WriteLine(player.ToString());
            }            
        }

        public void EditPlayers () 
        {
            Console.WriteLine("Informe o ID do jogador a ser editado");
            int playerId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Quantidade de Tickets possuidos:");
            float tickets = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Quantidade de jogos ganhos:");
            int gamesWon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Quantidade de jogos perdidos:");
            int gamesLost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            playerController.Edit(playerId, name, tickets,gamesWon, gamesLost);
        }

        public void RemovePlayers ()
        {
            Console.WriteLine("Informe o ID do jogador a ser deletado");
            int playerId = Convert.ToInt32(Console.ReadLine());

            playerController.Remove(playerId);
        }



               
    }
}
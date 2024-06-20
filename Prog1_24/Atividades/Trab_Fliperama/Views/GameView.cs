using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Controllers;
using Trab_Fliperama.Models;
using Trab_Fliperama.Games;

namespace Trab_Fliperama.Views
{
    public class GameView
    {
        private GameController gameController;

        public GameView() 
        {
            gameController = new GameController();
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
                Console.WriteLine("1 - Inserir Jogos");
                Console.WriteLine("2 - Pesquisar Jogos");
                Console.WriteLine("3 - Lista todos os Jogos");
                Console.WriteLine("4 - Editar Jogos");
                Console.WriteLine("5 - Remover Jogos");
                Console.WriteLine("6 - Testar Jogos");
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
                            InsertGame();
                        break;
                        case 2:
                            SearchGame();
                        break;
                        case 3: 
                            ListGame();
                        break;
                        case 4:
                            EditGame();
                        break;
                        case 5:
                            RemoveGame();
                        break;
                        case 6:
                            TestGames();
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

        private void InsertGame()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("INSERIR NOVO JOGO");
            Console.WriteLine("------------------");

            Game game = new Game();
            
            Console.Write("Nome:");
            game.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Genero do jogo:");
            game.Genre = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Descrição do jogo:");
            game.Description = Console.ReadLine();
            Console.WriteLine("");

            try
            {
                gameController.Insert(game);
                Console.WriteLine("Jogo inserido com sucesso!");
            }
            catch
            {
                Console.WriteLine("Ocorreu um erro na inserção do Jogo");
            }
        }

        private void SearchGame()
        {    
            int aux = -1;
            do
            {
                Console.WriteLine("PESQUISAR JOGO");
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
            Game? g = gameController.Get(id);

            if(g != null)
            {
                Console.WriteLine(g.ToString());
            }
            else
            {
                Console.WriteLine($"Consumidor de id {id} não encontrado!");
            }
        }

        private void ShowPlayersByName(string name)
        {
            List<Game> result = gameController.GetByName(name);

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado.");
                return;                
            }

            foreach(Game game in result)
            {
                Console.WriteLine(game.ToString());
            }
        }

        private void ListGame()
        {
            List<Game> result = gameController.Get();

            if( (result == null || result?.Count == 0 ))
            {
                Console.WriteLine("Não encontrado.");
                return;                
            }

            foreach(Game game in result)
            {
                Console.WriteLine(game.ToString());
            }            
        }

        public void EditGame () 
        {
            Console.WriteLine("Informe o ID do jogo a ser editado");
            int gameId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nome:");
            string name = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Genero do jogo:");
            string genre = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Descrição do jogo:");
            string description = Console.ReadLine();
            Console.WriteLine("");

            gameController.Edit(gameId, name, genre, description);
        }

        public void RemoveGame ()
        {
            Console.WriteLine("Informe o ID do jogo a ser deletado");
            int gameId = Convert.ToInt32(Console.ReadLine());

            gameController.Remove(gameId);
        }

        public void TestGames()
        {
            int aux = -1;
            do
            {
                Console.WriteLine("SELECIONAR JOGO");
                Console.WriteLine("------------------");
                Console.WriteLine("1 - Adivinhe o Numero");
                Console.WriteLine("0 - Sair");   

                string menuOpt = Console.ReadLine();
                aux = Convert.ToInt16(menuOpt);
                switch(aux)
                {
                    case 1:
                        GuessANumber guessANumber = new GuessANumber();
                    break;
                    case 2:
                        DiceGame diceGame = new DiceGame();
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

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Repository;

namespace Trab_Fliperama.Controllers
{
    public class GameController
    {
        private GameRepository gameRepository;

        public GameController()
        {
            gameRepository = new GameRepository();
        } 

        public void Insert(Game game)
        {
             gameRepository.Save(game);
        }

        public void Edit(int gameId, string name, string genre, string description) {
            gameRepository.EditGame(gameId, name, genre, description);
        }

        public void Remove(int gameId) {
            gameRepository.DeleteGame(gameId);
        }

        public Game Get(int id)
        {            
            return gameRepository.Retrieve(id);
        }

        public List<Game> Get()
        {
            return gameRepository.Retrieve();
        }

        public List<Game> GetByName(string name)
        {
            return gameRepository.RetrieveByName(name);
        }

        internal void Edit(string? name, float tickets, int gamesWon, int gamesLost)
        {
            throw new NotImplementedException();
        }
    }
}
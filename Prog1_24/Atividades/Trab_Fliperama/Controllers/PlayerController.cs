using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Repository;

namespace Trab_Fliperama.Controllers
{
    public class PlayerController
    {

        private PlayerRepository playerRepository;

        public PlayerController()
        {
            playerRepository = new PlayerRepository();
        } 

        public void Insert(Player player)
        {
             playerRepository.Save(player);
        }

        public void Edit(int playerId, string name, float tickets, int gamesWon, int gamesLost) {
            playerRepository.EditPlayer(playerId, name, tickets, gamesWon, gamesLost);
        }

        public void Remove(int playerId) {
            playerRepository.DeletePlayer(playerId);
        }

        public Player Get(int id)
        {            
            return playerRepository.Retrieve(id);
        }

        public List<Player> Get()
        {
            return playerRepository.Retrieve();
        }

        public List<Player> GetByName(string name)
        {
            return playerRepository.RetrieveByName(name);
        }

        internal void Edit(string? name, float tickets, int gamesWon, int gamesLost)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Data;

namespace Trab_Fliperama.Repository
{
    public class PlayerRepository
    {

        // Guarda Jogadores, gera ID automaticamentes pela função de GetNextId
        public void Save(Player player, bool autoGenerateId = true)
        {
            if(autoGenerateId)
                player.PlayerId = this.GetNextId();

            DataSet.Players.Add(player);
        }

        // Realiza a pesquisa de jogadores pelo o ID
        public Player Retrieve(int id)
        {            
            foreach(var p in DataSet.Players)
            {
                if( p.PlayerId == id )                
                    return p;                
            }

            return null;
        }

        // Realiza a pesquisa através dos nomes dos jogadores
        public List<Player> RetrieveByName(string name)
        {
            List<Player> retorno = new List<Player>();
            foreach(var p in DataSet.Players)
            {
                if(p.Name.Contains(name))
                {
                    retorno.Add(p);
                }
            }
            return retorno;
        }

        // Realiza a listagem de todos os jogadores
        public List<Player> Retrieve()
        {
            return DataSet.Players;
        }

        // Edita as informações dos jogadores
        public void EditPlayer (int playerId, string name, float tickets, int gamesWon, int gamesLost ) 
        {
            foreach(var p in DataSet.Players)
            {
                if (p.PlayerId == playerId) 
                {
                        p.Name = name;
                        p.Tickets = tickets;
                        p.GamesLost = gamesLost;
                        p.GamesWon = gamesWon;
                }
            }
        }

        // Remove Jogadores
        public bool DeletePlayer(int playerId)
        {
            return DataSet.Players.Remove(this.Retrieve(playerId));
        }


        private int GetNextId()
        {
            int n = 0;
            foreach(var p in DataSet.Players)
            {
                if(p.PlayerId > n)                
                    n = p.PlayerId;
            }

            return ++n;
        }

    }
}
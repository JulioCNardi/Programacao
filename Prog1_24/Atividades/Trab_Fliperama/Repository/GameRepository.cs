using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Data;

namespace Trab_Fliperama.Repository
{
    public class GameRepository
    {
        // Guarda Jogos, gera ID automaticamentes pela função de GetNextId
        public void Save(Game game, bool autoGenerateId = true)
        {
            if(autoGenerateId)
                game.GameId = this.GetNextId();

            DataSet.Games.Add(game);
        }

        // Realiza a pesquisa de jogos pelo o ID
        public Game Retrieve(int id)
        {            
            foreach(var g in DataSet.Games)
            {
                if( g.GameId == id )                
                    return g;                
            }

            return null;
        }

        // Realiza a pesquisa através dos nomes dos jogos
        public List<Game> RetrieveByName(string name)
        {
            List<Game> retorno = new List<Game>();
            foreach(var g in DataSet.Games)
            {
                if(g.Name.Contains(name))
                {
                    retorno.Add(g);
                }
            }
            return retorno;
        }

        // Realiza a listagem de todos os jogos
        public List<Game> Retrieve()
        {
            return DataSet.Games;
        }
        
        public void EditGame (int gameId, string name, string genre, string description) 
        {
            foreach(var g in DataSet.Games)
            {
                if (g.GameId == gameId) 
                {
                        g.Name = name;
                        g.Genre = genre;
                        g.Description = description;
                }
            }
        }

        public bool DeleteGame(int gameId)
        {
            return DataSet.Games.Remove(this.Retrieve(gameId));
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
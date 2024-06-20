using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trab_Fliperama.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public float Tickets { get; set; }      
        public int GamesWon { get; set; } 
        public int GamesLost { get; set; } 

        public override string ToString()
        {            
            return $"{PlayerId} - {this.Name} - {Tickets} - {GamesWon} - {GamesLost} ";
        }
        
    }
    

}
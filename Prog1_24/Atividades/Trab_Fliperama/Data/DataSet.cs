using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;


namespace Trab_Fliperama.Data
{
    public class DataSet
    {
        public static List<Player> Players { get; set; } = new List<Player>();
        public static List<Game> Games { get; set; } = new List<Game>();
    }
}
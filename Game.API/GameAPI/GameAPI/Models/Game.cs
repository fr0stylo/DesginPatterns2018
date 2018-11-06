using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public int CurrentLevel { get; set; }
        public ICollection<Tower> Towers { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Baloon> Baloons { get; set; }
    }
}

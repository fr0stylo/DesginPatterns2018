using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Models
{
    public class Baloon
    {
        public int BaloonId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Type { get; set; }
        public bool AttackPlayer1 { get; set; }
        public bool AttackPlayer2 { get; set; }

    }
}

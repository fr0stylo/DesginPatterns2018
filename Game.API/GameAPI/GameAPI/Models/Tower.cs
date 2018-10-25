using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Models
{
    public class Tower
    {
        public int TowerId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public string Type { get; set; }
        public bool DefendPlayer1 { get; set; }
        public bool DefendPlayer2 { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAPI.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MoneyPoints { get; set; }

        public int HealthPoints { get; set; }   

        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}
